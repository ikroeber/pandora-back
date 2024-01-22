using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Application.Dto
{
    public record ProjectDto(Guid UserId,
                             Guid CreatedBy,
                             string Name);
}
