using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReziRoster.API.Domains;
using ReziRoster.API.Models;
using System.Threading.Tasks;

namespace ReziRoster.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    class UserController
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, UserDomain domain)
        {
            _logger = logger;
            _domain = domain;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(string id)
        {
            var user = await _domain.GetByID(id);

            if (user == null)
            {
                return NotFoundResult();
            }

            return user;

        }

        private readonly UserDomain _domain;
    }
}
