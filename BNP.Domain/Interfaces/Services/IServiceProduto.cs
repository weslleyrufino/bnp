using BNP.Domain.Arguments.Produto;
using BNP.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace BNP.Domain.Interfaces.Services
{
    public interface IServiceProduto : IServiceBase
    {
        IEnumerable<ProdutoResponse> ListarProduto();
    }
}
