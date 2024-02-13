using Microsoft.AspNetCore.Mvc;

using Pandora.Application.Dto;
using Pandora.Application.Services;

namespace Pandora.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class UsersController(IUserService userServices) : PandoraAPIController
    {
        private readonly IUserService _userServices = userServices;

        [HttpPost]
        public UserDto AddUser(CreateUserDto createUserDto)
        {
            UserDto user = _userServices.AddNewUser(createUserDto);
            return user;
        }

        [HttpGet]
        [Route("{userId:guid}")]
        public UserDto? GetUserById(Guid userId)
        {
            UserDto? user = _userServices.GetUserById(userId);
            return user;
        }

        [HttpGet]
        public IEnumerable<UserDto> GetUsers()
        {
            IEnumerable<UserDto> users = _userServices.GetUsers();
            return users;
        }
    }
}
