using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Pandora.Domain;
using Pandora.Domain.Entities;

namespace Pandora.Infrastructure.Persistence.EFCore.Repositories
{
    public class EFCoreRepository<T>(PandoraContext context) : IRepository<T> where T : Entity
    {
        private readonly PandoraContext _context = context;
        private readonly DbSet<T> _entitySet = context.Set<T>();
        private static readonly char[] Separator = [','];

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public IEnumerable<T> Get(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = _entitySet;

            if (filter != null) { query = query.Where(filter); }

            string[] includedProperties = includeProperties.Split(Separator,
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var includedProperty in includedProperties)
            {
                query = query.Include(includedProperty);
            }

            return orderBy != null ? orderBy(query).ToList() : query.ToList();
        }

        public T GetById(object id)
        {
            return _entitySet.Find(id)!;
        }

        public void Remove(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _entitySet.Attach(entity);
            }
            _entitySet.Remove(entity);
        }

        public void RemoveById(object id)
        {
            T entity = _entitySet.Find(id)!;
            Remove(entity);
        }

        public void Update(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _entitySet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }
        }
    }
}
