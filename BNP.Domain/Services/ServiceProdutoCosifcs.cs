using BNP.Domain.Arguments.ProdutoCosfi;
using BNP.Domain.Interfaces.Repositories;
using BNP.Domain.Interfaces.Services;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;
using System.Linq;

namespace BNP.Domain.Services
{
    public class ServiceProdutoCosif : Notifiable, IServiceProdutoCosif
    {
        private readonly IRepositoryProdutoCosif _repositoryProdutoCosif;

        public ServiceProdutoCosif(IRepositoryProdutoCosif repositoryProdutoCosif)
        {
            _repositoryProdutoCosif = repositoryProdutoCosif;
        }

        public IEnumerable<ProdutoCosfiResponse> ListarProdutoCosif()
        {
            return _repositoryProdutoCosif.Listar(x=>x.Produto)
                .ToList()
                .Select(produtoCosif => (ProdutoCosfiResponse)produtoCosif)
                .ToList();
        }
    }
}
