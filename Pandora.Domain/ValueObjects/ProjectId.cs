using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Domain.ValueObjects
{
    public class ProjectId : UniqueId
    {
        private ProjectId(Guid value) : base(value) { }

        public static ProjectId Create()
        {
            return new ProjectId(Guid.NewGuid());
        }

        public static ProjectId From(Guid value)
        {
            return new ProjectId(value);
        }
    }
}
