using ReziRoster.API.Models;
using ReziRoster.API.Repositories.MockRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ReziRoster.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReziRosterController : ControllerBase
    {
        private readonly ILogger<ReziRosterController> _logger;

        public ReziRosterController(ILogger<ReziRosterController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Player>> GetPlayerById(Guid rosterId)
        {
            using var reader = new StreamReader(Request.Body);
            var body = reader.ReadToEndAsync();
            var fml = body.Result;
            var mockPlayerRepository = new MockPlayerRepository();
            var myTask = Task.Run(() => mockPlayerRepository.GetPlayerById(rosterId));
            Player player = await myTask;
            return (IEnumerable<Player>)player;

        }
    }
}
