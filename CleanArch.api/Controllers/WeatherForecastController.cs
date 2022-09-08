using Microsoft.AspNetCore.Mvc;
using CleanArch.BLL;

namespace CleanArch.api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherService _weatherService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
    IWeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get(string cityName = "Delhi", int numberOfDays = 3)
    {
        return _weatherService.Get(cityName, numberOfDays);
    }
}
