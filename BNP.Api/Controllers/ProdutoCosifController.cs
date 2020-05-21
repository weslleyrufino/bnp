using BNP.Api.Controllers.Base;
using BNP.Domain.Interfaces.Services;
using BNP.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BNP.Api.Controllers
{
    [RoutePrefix("api/produtoCosif")]
    public class ProdutoCosifController : ControllerBase
    {
        private readonly IServiceProdutoCosif _serviceProdutoCosif;

        public ProdutoCosifController(IUnitOfWork unitOfWork, IServiceProdutoCosif serviceProdutoCosif) : base(unitOfWork)
        {
            _serviceProdutoCosif = serviceProdutoCosif;
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _serviceProdutoCosif.ListarProdutoCosif();

                return await ResponseAsync(response, _serviceProdutoCosif);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }


    }
}