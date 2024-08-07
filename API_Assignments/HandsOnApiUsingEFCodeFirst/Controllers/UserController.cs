using HandsOnApiUsingEFCodeFirst.Entities;
using HandsOnApiUsingEFCodeFirst.Repositories;
using HandsOnAPIUsingEFCodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //public UserController()
        //{
        //    _userRepository = new UserRepository();
        //}
        [HttpPost, Route("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User data is null.");
            }

            _userRepository.Register(user);
            return Ok("User registered successfully.");
        }
        [HttpPost]
        [Route("Validate")]
        public IActionResult ValidateUser(Login login)
        { 
            var users = _userRepository.ValidUser(login.Email,login.Password);
            if (users != null)
            {
                return StatusCode(200, users);
            }
            return StatusCode(404, "Not Found");

        }
    }
}
