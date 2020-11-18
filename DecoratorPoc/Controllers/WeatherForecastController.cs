using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventbusPoc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DecoratorPoc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPublisher _publisher;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IPublisher publisher)
        {
            _logger = logger;
            _publisher = publisher;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _publisher.PublishAsync(new SampleEvent(), new Dictionary<string, string>());

            return Ok();
        }
    }
}
