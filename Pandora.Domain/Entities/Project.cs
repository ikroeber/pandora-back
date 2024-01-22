using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using Pandora.Domain.ValueObjects;

namespace Pandora.Domain.Entities
{
    public class Project : Entity
    {
        protected Project(ProjectId projectId, User owner, string name, DateTime createdAt, DateTime updatedAt)
        {
            ProjectId = projectId;
            Owner = owner;
            Name = name;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public ProjectId ProjectId { get; private set; }
        public User Owner { get; private set; }
        public string Name { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public static Project Create(User owner, string name)
        {
            return new Project(ProjectId.Create(), owner, name, DateTime.Now, DateTime.Now);
        }

        public static Project From(ProjectId projectId, User owner, string name, DateTime createdAt, DateTime updatedAt)
        {
            return new Project(projectId, owner, name, createdAt, updatedAt);
        }
    }
}
