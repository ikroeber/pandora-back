using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Application.Dto

{    public record UserDto(Guid UserId,
                          string Email,
                          string FirstName,
                          string LastName);
}
