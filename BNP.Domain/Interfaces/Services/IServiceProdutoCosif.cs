using BNP.Domain.Arguments.ProdutoCosfi;
using BNP.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace BNP.Domain.Interfaces.Services
{
    public interface IServiceProdutoCosif : IServiceBase
    {
        IEnumerable<ProdutoCosfiResponse> ListarProdutoCosif();
    }
}
