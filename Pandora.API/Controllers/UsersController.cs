using Microsoft.AspNetCore.Mvc;

using Pandora.Application.Dto;
using Pandora.Application.Services;
using Pandora.Domain.ValueObjects;

namespace Pandora.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class UsersController : PandoraAPIController
    {
        private readonly IUserService _userServices;

        public UsersController(IUserService userServices)
        {
            _userServices = userServices;
        }

        [HttpPost]
        public UserDto AddUser(UserDto userDTO)
        {
            userDTO = _userServices.AddNewUser(userDTO);
            return userDTO;
        }

        [HttpGet]
        [Route("{userId:guid}")]
        public UserDto? GetUserById(Guid userId)
        {
            UserDto? userDTO = _userServices.GetUserById(userId);
            return userDTO;
        }

        [HttpGet]
        public IEnumerable<UserDto> GetUsers()
        {
            IEnumerable<UserDto> users = _userServices.GetUsers();
            return users;
        }
    }
}
