using System;
using System.Collections.Generic;
using EasyRoster.API.Repositories.MockRepositories;
using EasyRoster.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace EasyRoster.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EasyRosterController : ControllerBase
    {
        private readonly ILogger<EasyRosterController> _logger;

        public EasyRosterController(ILogger<EasyRosterController> logger)
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
