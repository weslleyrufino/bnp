using BNP.Domain.Entities;
using BNP.Domain.Interfaces.Repositories;
using BNP.Infra.Persistence.Repositories.Base;

namespace BNP.Infra.Persistence.Repositories
{
    public class RepositoryMovimentoManual : RepositoryBase<MovimentoManual>, IRepositoryMovimentoManual
    {
        protected readonly BNPContext _context;

        public RepositoryMovimentoManual(BNPContext context) : base(context)
        {
            _context = context;
        }
    }
}
