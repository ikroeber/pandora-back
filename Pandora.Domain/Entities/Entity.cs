using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Domain
{
    public abstract class Entity
    {
        public UniqueId Id { get; set; }
    }
}
