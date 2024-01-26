using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pandora.Domain;
using Pandora.Domain.Entities;

namespace Pandora.Domain
{
    public interface IUnitOfWork
    {
        public IRepository<T> GetRepository<T>() where T : Entity;
        public void SaveChanges();
    }
}
