using Microsoft.AspNetCore.Mvc;
using Prerender.shared;

namespace Prerender.server.Controllers
{
    [ApiController]
    [Route("api/[CONTROLLER]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherforecastService _weatherForecastService;

        public WeatherForecastController(IWeatherforecastService weatherService)
        {
            _weatherForecastService = weatherService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _weatherForecastService.GetForecastAsync();
        }
    }
}