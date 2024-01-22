using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pandora.Domain;
using Pandora.Domain.Entities;
using Pandora.Domain.ValueObjects;

namespace Pandora.Infrastructure.Persistence.EFCore.Repositories
{
    public class UserRepository(PandoraContext context) : IUserRepository
    {
        private readonly PandoraContext _context = context;

        public void AddNewUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public User? GetUserById(Guid id)
        {
            User? user = _context.Users
                                 .Where(u => u.UserId == UserId.From(id))
                                 .FirstOrDefault();
            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            IEnumerable<User> users = _context.Users;
            return users;
        }
    }
}
