using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pandora.Application.Dto;
using Pandora.Domain;
using Pandora.Domain.Entities;
using Pandora.Domain.Mappings;

namespace Pandora.Application.Services
{
    public class UserService(IUserRepository userRepository, IMapper<User, UserDto> mapper) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;
        private readonly IMapper<User, UserDto> _mapper = mapper;

        public UserDto AddNewUser(UserDto userDTO)
        {
            User user = _mapper.ToDomain(userDTO);
            _userRepository.AddNewUser(user);
            return userDTO;
        }

        public UserDto? GetUserById(Guid id)
        {
            User? user = _userRepository.GetUserById(id);

            if (user == null) { return null; }

            UserDto? userDTO = _mapper.ToDTO(user);
            return userDTO;
        }

        public IEnumerable<UserDto> GetUsers()
        {
            IEnumerable<User> users = _userRepository.GetUsers();
            IEnumerable<UserDto> userDTOs = users.Select(user => _mapper.ToDTO(user));
            return userDTOs;
        }
    }
}
