using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using Pandora.Application.Dto;
using Pandora.Domain.Entities;
using Pandora.Domain.ValueObjects;

namespace Pandora.Application.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserId, Guid>().ConvertUsing(userId => userId.Value);
            CreateMap<User, UserDto>();
            CreateMap<CreateUserDto, User>().ConvertUsing(dto => User.Create(dto.Email, dto.FirstName, dto.LastName));

        }
    }
}
