using _2025_02_25_epita_faker.Models;
using _2025_02_25_epita_faker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace _2025_02_25_epita_faker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly IMemoryCache _cache;
        public UserProfileController(IMemoryCache cache)
        {
            _cache = cache;
        }
        // GET: api/UserProfile
        [HttpGet]
        public IActionResult Get()
        {
            const string cacheKey = "userProfiles";

            if (!_cache.TryGetValue(cacheKey, out List<UserProfile> userProfiles))
            {
                userProfiles = GenerateUserProfiles.GenerateProfiles(100);
                _cache.Set(cacheKey, userProfiles, TimeSpan.FromMinutes(1));
            }


           
            return Ok(userProfiles);
        }

        // GET: api/UserProfile
        [Authorize] // Requires a valid JWT
        [HttpGet("AuthorisedProfiles")]
        public IActionResult GetAuthorisedProfiles()
        {
            const string cacheKey = "userProfiles";

            if (!_cache.TryGetValue(cacheKey, out List<UserProfile> userProfiles))
            {
                userProfiles = GenerateUserProfiles.GenerateProfiles(100);
                _cache.Set(cacheKey, userProfiles, TimeSpan.FromMinutes(1));
            }



            return Ok(userProfiles);
        }
    }
}
