using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeChallenge.API.Models;
using CodeChallenge.API.Services;
using Newtonsoft.Json;

namespace CodeChallenge.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class LaunchpadController : ControllerBase
    {
        private readonly ILaunchpadService _launchpadService;

        public LaunchpadController(ILaunchpadService launchpadService)
        {
            _launchpadService = launchpadService;
        }

        [HttpGet("launchpad/{id}")]
        [ProducesResponseType(200, Type = typeof(LaunchpadDto))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAsync(string id)
        {
            var result = await _launchpadService.GetLaunchpadAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            var json = JsonConvert.SerializeObject(result);

            return Ok(json);
        }

        [HttpGet("launchpads")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<LaunchpadDto>))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _launchpadService.GetAllLaunchpadsAsync();

            if (result == null)
            {
                return NotFound();
            }

            var json = JsonConvert.SerializeObject(result);

            return Ok(json);
        }
    }
}
