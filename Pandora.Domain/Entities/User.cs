using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pandora.Domain.ValueObjects;

namespace Pandora.Domain.Entities
{
    public class User : Entity
    {
        protected User(UserId userId, string email, string firstName, string lastName)
        {
            UserId = userId;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }

        public UserId UserId { get; private set; }
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public static User Create(string email, string firstName, string lastName)
        {
            return new User(UserId.Create(), email, firstName, lastName);
        }

        public static User From(UserId userId, string email, string firstName, string lastName)
        {
            return new User(userId, email, firstName, lastName);
        }
    }
}
