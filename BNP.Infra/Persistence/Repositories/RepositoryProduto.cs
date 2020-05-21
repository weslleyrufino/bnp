using BNP.Domain.Entities;
using BNP.Domain.Interfaces.Repositories;
using BNP.Infra.Persistence.Repositories.Base;

namespace BNP.Infra.Persistence.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        protected readonly BNPContext _context;

        public RepositoryProduto(BNPContext context) : base(context)
        {
            _context = context;
        }
    }
}
