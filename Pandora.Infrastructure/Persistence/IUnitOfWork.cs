using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Infrastructure.Persistence
{
    public interface IUnitOfWork
    {
        public void Commit();
    }
}
