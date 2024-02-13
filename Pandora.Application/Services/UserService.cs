using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using Pandora.Application.Dto;
using Pandora.Domain;

namespace Pandora.Application.Services
{
    public class UserService(IUnitOfWork unitOfWork, IMapper mapper) : IUserService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        private readonly IMapper _mapper = mapper;

        public UserDto AddNewUser(CreateUserDto createUserDTO)
        {
            User user = _mapper.Map<User>(createUserDTO);

            IRepository<User> repository = _unitOfWork.GetRepository<User>();
            repository.Add(user);
            _unitOfWork.SaveChanges();

            return _mapper.Map<UserDto>(user);
        }

        public UserDto? GetUserById(Guid id)
        {
            IRepository<User> repository = _unitOfWork.GetRepository<User>();
            User user = repository.GetById(id);
            return _mapper.Map<UserDto>(user);
        }

        public IEnumerable<UserDto> GetUsers()
        {
            IRepository<User> repository = _unitOfWork.GetRepository<User>();
            IEnumerable<UserDto> userDTOs = repository.Get().Select(_mapper.Map<UserDto>);
            return userDTOs;
        }
    }
}
