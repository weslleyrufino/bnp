using BNP.Domain.Arguments.MovimentoManual;
using BNP.Domain.Interfaces.Services.Base;
using System.Collections.Generic;


namespace BNP.Domain.Interfaces.Services
{
    public interface IServiceMovimentoManual : IServiceBase
    {
        IEnumerable<MovimentoManualResponse> ListarMovimentoManual();

        AdicionarMovimentoManualResponse AdicionarMovimentoManual(AdicionarMovimentoManualRequest request);
    }
}
