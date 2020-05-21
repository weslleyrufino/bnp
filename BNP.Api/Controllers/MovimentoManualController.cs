using BNP.Api.Controllers.Base;
using BNP.Domain.Arguments.MovimentoManual;
using BNP.Domain.Interfaces.Services;
using BNP.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BNP.Api.Controllers
{
    [RoutePrefix("api/movimentoManual")]
    public class MovimentoManualController : ControllerBase
    {
        private readonly IServiceMovimentoManual _serviceMovimentoManual;

        public MovimentoManualController(IUnitOfWork unitOfWork, IServiceMovimentoManual serviceMovimentoManual) : base(unitOfWork)
        {
            _serviceMovimentoManual = serviceMovimentoManual;
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _serviceMovimentoManual.ListarMovimentoManual();

                return await ResponseAsync(response, _serviceMovimentoManual);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarMovimentoManualRequest request)
        {
            try
            {
                var respose = _serviceMovimentoManual.AdicionarMovimentoManual(request);

                return await ResponseAsync(respose, _serviceMovimentoManual);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}