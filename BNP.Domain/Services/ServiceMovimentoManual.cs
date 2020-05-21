using BNP.Domain.Arguments.MovimentoManual;
using BNP.Domain.Entities;
using BNP.Domain.Interfaces.Repositories;
using BNP.Domain.Interfaces.Services;
using BNP.Domain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace BNP.Domain.Services
{
    public class ServiceMovimentoManual : Notifiable, IServiceMovimentoManual
    {
        private readonly IRepositoryMovimentoManual _repositoryMovimentoManual;

        public ServiceMovimentoManual(IRepositoryMovimentoManual repositoryMovimentoManual)
        {
            _repositoryMovimentoManual = repositoryMovimentoManual;
        }

        public IEnumerable<MovimentoManualResponse> ListarMovimentoManual()
        {
            return _repositoryMovimentoManual
               .Listar(x => x.Produto)
               .ToList()
               .Select(movimentoManual => (MovimentoManualResponse)movimentoManual)
               .OrderBy(x => x.DAT_MES)
               .ThenBy(x => x.DAT_ANO)
               .ThenBy(x=>x.NUM_LANCAMENTO)

               .ToList();
        }

        public AdicionarMovimentoManualResponse AdicionarMovimentoManual(AdicionarMovimentoManualRequest request)
        {
            MovimentoManual Movimento = new MovimentoManual(request);

            //AddNotification(Movimento);

            //var verificaSeJaExisteNaBase = _repositoryMovimentoManual.Existe(
            //            x => 
            //            x.DAT_MES == request.DAT_MES &&
            //            x.DAT_ANO == request.DAT_ANO &&
            //            x.VAL_VALOR == request.VAL_VALOR &&
            //            x.DES_DESCRICAO == request.DES_DESCRICAO);

            //if (verificaSeJaExisteNaBase)
            //{
            //   AddNotification("Movimento", Message.JA_EXISTE_UM_X0_CHAMADO_X1.ToFormat("movimento", request.))
            //}

            Movimento = _repositoryMovimentoManual.Adicionar(Movimento);

            return (AdicionarMovimentoManualResponse)Movimento;
        }
    }
}
