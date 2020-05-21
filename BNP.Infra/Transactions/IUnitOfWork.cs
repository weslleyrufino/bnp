using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
