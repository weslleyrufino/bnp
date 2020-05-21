using BNP.WebFront.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;

namespace BNP.WebFront.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<MovimentoManualViewModelResponse> Movimentos = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55036/api/movimentoManual/");

                // HTTP GET
                var responseTask = client.GetAsync("Listar");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<MovimentoManualViewModelResponse>>();
                    readTask.Wait();

                    Movimentos = readTask.Result;
                }
                else
                {
                    Movimentos = Enumerable.Empty<MovimentoManualViewModelResponse>();
                    ModelState.AddModelError(string.Empty, "Erro no servidor. Por favor, contacte o administrador.");
                }
            }

            return View(Movimentos);
        }
        
        public ActionResult CriarMovimentoManual()
        {
            IEnumerable<ProdutoCosifViewModelResponse> ProdutoCosif = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55036/api/produtoCosif/");

                // HTTP GET
                var responseTask = client.GetAsync("Listar");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ProdutoCosifViewModelResponse>>();
                    readTask.Wait();

                    ProdutoCosif = readTask.Result;
                    ViewBag.ViewCodProduto = new SelectList(ProdutoCosif.Select(x => x.COD_PRODUTO).Distinct(), "COD_PRODUTO");
                    ViewBag.ViewCodCosif = new SelectList(ProdutoCosif.Select(x => x.COD_COSIF), "COD_COSIF");
                }
                else
                {
                    ProdutoCosif = Enumerable.Empty<ProdutoCosifViewModelResponse>();
                    ModelState.AddModelError(string.Empty, "Erro no servidor. Por favor, contacte o administrador.");
                }
            }

            return View(new MovimentoEProdutoCosif());
        }

        [HttpPost]
        public ActionResult CriarMovimentoManual(MovimentoEProdutoCosif movimento)
        {
            using (var client = new HttpClient())
            {
                Convert.ToDecimal(movimento.MovimentoManual.VAL_VALOR);// Não é a melhor prática, mas tive dificuldade no front para deixar como decimal e persistir na tabela.
                movimento.MovimentoManual.COD_PRODUTO = movimento.COD_PRODUTO;
                movimento.MovimentoManual.COD_COSIF = movimento.COD_COSIF;

                client.BaseAddress = new Uri("http://localhost:55036/api/movimentoManual/");

                // HTTP POST
                var postTask = client.PostAsJsonAsync<MovimentoManualViewModelRequest>("Adicionar", movimento.MovimentoManual);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                    return RedirectToAction("Index");
            }

            return View();
        }
    }
}