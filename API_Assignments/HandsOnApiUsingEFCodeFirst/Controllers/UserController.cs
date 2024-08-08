using HandsOnApiUsingEFCodeFirst.Entities;
using HandsOnApiUsingEFCodeFirst.Models;
using HandsOnApiUsingEFCodeFirst.Repositories;
using HandsOnAPIUsingEFCodeFirst.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HandsOnApiUsingEFCodeFirst.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private IConfiguration _configuration;
        public UserController(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        //public UserController()
        //{
        //    _userRepository = new UserRepository();
        //}
        [HttpPost, Route("Register")]
        [AllowAnonymous] //any user can access without login
        public IActionResult Register(User user)
        {
            _userRepository.Register(user);
            return Ok(user);
        }
        [HttpPost]
        [Route("Validate")]
        [AllowAnonymous]//any user can access without login
        public IActionResult ValidateUser(Login login)
        {
            {
                AuthReponse authReponse = null;
                var user = _userRepository.ValidUser(login.Email, login.Password);
                if (user != null)
                {
                    authReponse = new AuthReponse()
                    {
                        UserId = user.UserId,
                        Role = user.Role,
                        Token = GetToken(user),
                    };
                }
                return Ok(authReponse);
            }

        }
    
        private string GetToken(User user)
        {
            var issuer = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
            //Header section
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature
            );
            //Payload section
            var subject = new ClaimsIdentity(new[]
            {
                        new Claim(ClaimTypes.Name,user.Name),
                        new Claim(ClaimTypes.Role, user.Role),
                    });

            var expires = DateTime.UtcNow.AddMinutes(10);//token will expire after 10min

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = subject,
                Expires = expires,
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = signingCredentials
            };
            //generate token using tokenDescription
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            return jwtToken;
        }
    }

}