using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Pandora.Domain;

namespace Pandora.Infrastructure.Persistence.EFCore
{
    public class UnitOfWork(PandoraContext context) : IUnitOfWork
    {
        private readonly PandoraContext _context = context;
        private readonly List<object> _repositories = [];

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public IRepository<T> GetRepository<T>() where T : Entity
        {
            if (!_repositories.Any(r => r is IRepository<T>))
            {
                IRepository<T> repo = new EFCoreRepository<T>(_context);
                _repositories.Add(repo);
                return repo;
            }

            return (_repositories.Single(r => r is IRepository<T>) as IRepository<T>)!;
        }
    }
}
