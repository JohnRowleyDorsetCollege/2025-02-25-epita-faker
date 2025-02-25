using _2025_02_25_epita_faker.Models;
using _2025_02_25_epita_faker.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace _2025_02_25_epita_faker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

        public class AuthController : ControllerBase
        {
            private readonly JwtService _jwtService;

            public AuthController(JwtService jwtService)
            {
                _jwtService = jwtService;
            }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequestForm request)
        {
            if (request.Username == "admin" && request.Password == "password") // Replace with actual authentication
            {
                var token = _jwtService.GenerateToken(request.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized(new { Message = "Invalid username or password" });
        }

        //[HttpGet("Token")]
        //public IActionResult Token()
        //{

        //        var token = _jwtService.GenerateToken("Bruce Wayne");
        //        return Ok(new { Token = token });

        //}
    }
    }

