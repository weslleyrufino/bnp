using BNP.Domain.Entities;
using BNP.Domain.Interfaces.Repositories;
using BNP.Infra.Persistence.Repositories.Base;

namespace BNP.Infra.Persistence.Repositories
{
    public class RepositoryProdutoCosif : RepositoryBase<ProdutoCosif>, IRepositoryProdutoCosif
    {
        protected readonly BNPContext _context;

        public RepositoryProdutoCosif(BNPContext context) : base(context)
        {
            _context = context;
        }
    }
}
