using CleanArch.DAL;
namespace CleanArch.BLL;
public class WeatherService : IWeatherService
{
    private readonly IWeatherDataRepository repository;
    public WeatherService(IWeatherDataRepository repository)
    {
        this.repository = repository;
    }
    public IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays)
    {
        return repository.Get(cityName, numberOfDays).Select(weatherDto => new WeatherForecast
        {
            Date = weatherDto.Date,
            Summary = weatherDto.Summary,
            TemperatureC = weatherDto.TemperatureC
        });
    }
}
