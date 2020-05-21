using BNP.Api.Controllers.Base;
using BNP.Domain.Interfaces.Services;
using BNP.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BNP.Api.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IServiceProduto _serviceProduto;

        public ProdutoController(IUnitOfWork unitOfWork, IServiceProduto serviceProduto) : base(unitOfWork)
        {
            _serviceProduto = serviceProduto;
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _serviceProduto.ListarProduto();

                return await ResponseAsync(response, _serviceProduto);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}