using BNP.Domain.Arguments.Produto;
using BNP.Domain.Interfaces.Repositories;
using BNP.Domain.Interfaces.Services;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;
using System.Linq;

namespace BNP.Domain.Services
{
    public class ServiceProduto : Notifiable,  IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public ServiceProduto()
        {

        }

        public ServiceProduto(IRepositoryProduto repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }

        public IEnumerable<ProdutoResponse> ListarProduto()
        {
            return _repositoryProduto.Listar().ToList().Select(produto => (ProdutoResponse)produto).ToList();
        }

    }
}
