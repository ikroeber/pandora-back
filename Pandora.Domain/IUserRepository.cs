using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pandora.Domain.Entities;

namespace Pandora.Domain
{
    public interface IUserRepository : IRepository<User>
    {
        public void AddNewUser(User user);
        public User? GetUserById(Guid id);
        public IEnumerable<User> GetUsers();
    }
}
