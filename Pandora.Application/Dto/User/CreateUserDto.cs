using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Application.Dto
{
    public record CreateUserDto(string Email,
                                string FirstName,
                                string LastName);
}
