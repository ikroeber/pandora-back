using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pandora.Application.Dto;
using Pandora.Domain;
using Pandora.Domain.Entities;
using Pandora.Domain.Mappings;
using Pandora.Domain.ValueObjects;

namespace Pandora.Application.Mappings
{
    public class UserMapper : IMapper<User, UserDto>
    {
        public User? ToDomain(UserDto? dto)
        {
            return dto is null
                ? null
                : User.From(
                UserId.From(dto.UserId),
                dto.Email,
                dto.FirstName,
                dto.LastName);
        }

        public UserDto? ToDTO(User? user)
        {
            return user is null
                ? null
                : new UserDto(user.UserId.Value,
                              user.Email,
                              user.FirstName,
                              user.LastName);
        }
    }
}
