using BNP.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BNPContext _context;

        public UnitOfWork(BNPContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
