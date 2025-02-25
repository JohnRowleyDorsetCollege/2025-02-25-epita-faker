using _2025_02_25_epita_faker.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2025_02_25_epita_faker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        // GET: api/UserProfile
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(GenerateUserProfiles.GenerateProfiles(100));
        }
    }
}
