using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Domain
{
    public class Project : Entity
    {
        protected Project(UniqueId projectId, User owner, string name)
        {
            ProjectId = projectId;
            Owner = owner;
            Name = name;
        }

        public UniqueId ProjectId { get; private set; }
        public User Owner { get; private set; }
        public string Name { get; private set; }

        public static Project Create(User owner, string name)
        {
            return new Project(UniqueId.Create(), owner, name);
        }

        public static Project From(UniqueId projectId, User owner, string name)
        {
            return new Project(projectId, owner, name);
        }
    }
}
