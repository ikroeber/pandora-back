using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Domain.ValueObjects
{
    public class UserId : UniqueId
    {
        private UserId(Guid value) : base(value) { }

        public static UserId Create()
        {
            return new UserId(Guid.NewGuid());
        }

        public static UserId From(Guid value)
        {
            return new UserId(value);
        }
    }
}
