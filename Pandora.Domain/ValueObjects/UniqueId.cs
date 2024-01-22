using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Domain.ValueObjects
{
    public abstract class UniqueId
    {
        public UniqueId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new ArgumentException(
                    $"{GetType().Name} cannot have an empty {nameof(Value)}.",
                    nameof(value));
            }

            Value = value;
        }

        public Guid Value { get; private set; }
    }
}
