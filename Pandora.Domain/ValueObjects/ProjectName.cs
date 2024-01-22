using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Domain.ValueObjects
{
    public class ProjectName
    {
        public ProjectName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Project name cannot be empty", nameof(name));

            Name = name;
        }

        public string Name { get; set; }
    }
}
