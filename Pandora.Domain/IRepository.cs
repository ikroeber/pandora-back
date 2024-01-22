using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Pandora.Domain.Entities;

namespace Pandora.Domain
{
    public interface IRepository<T> where T : Entity
    {
        public IEnumerable<T> Get(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string includeProperties = "");
        public T GetById(object id);
        public void Add(T entity);
        public void Update(T entity);
        public void RemoveById(object id);
        public void Remove(T entity);
    }
}
