using HandsOnApiUsingEFCodeFirst.Entities;
using HandsOnApiUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEFCodeFirst.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController()
        {
            _userRepository = new UserRepository();
        }
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
        [HttpPost, Route("Validate/{Email}/{Password}")]
        public IActionResult ValidateUser(string Email, string Password)
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                return BadRequest("Invalid Login Data");
            var users = _userRepository.ValidUser(Email,Password);
            if (users != null)
            {
                return StatusCode(200, User);
            }
            return StatusCode(404, "Not Found");

        }
    }
}
