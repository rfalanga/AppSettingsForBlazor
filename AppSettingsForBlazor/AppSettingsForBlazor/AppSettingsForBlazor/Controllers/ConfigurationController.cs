using Microsoft.AspNetCore.Mvc;

namespace AppSettingsForBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ConfigurationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("{key}")]
        public IActionResult GetConfiguration(string key)
        {
            var value = _configuration[key];
            return Ok(value ?? "Key not found");
        }
    }
}
