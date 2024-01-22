using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pandora.Application.Dto;

namespace Pandora.Application.Handlers.User
{
    public class IGetUsersHandler
    {
        public IEnumerable<UserDto> GetUsers();
    }
}
