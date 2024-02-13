using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Domain
{
    public class User : Entity
    {
        protected User(UniqueId userId, string email, string firstName, string lastName)
        {
            Id = userId;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public static User Create(string email, string firstName, string lastName)
        {
            return new User(UniqueId.Create(), email, firstName, lastName);
        }

        public static User From(UniqueId userId,
                                string email,
                                string firstName,
                                string lastName)
        {
            return new User(userId, email, firstName, lastName);
        }
    }
}
