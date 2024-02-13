using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pandora.Application.Dto;

namespace Pandora.Application.Services
{
    public interface IUserService
    {
        public UserDto AddNewUser(CreateUserDto createUserDTO);
        public UserDto? GetUserById(Guid id);
        public IEnumerable<UserDto> GetUsers();
    }
}
