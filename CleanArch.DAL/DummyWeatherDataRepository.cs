namespace CleanArch.DAL;
public class DummyWeatherDataRepository : IWeatherDataRepository
{
    private static readonly string[] Summaries = new[]
   {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    public IEnumerable<WeatherForecastDto> Get(string cityName, int numberOfDays)
    {
        return Enumerable.Range(1, numberOfDays).Select(index => new WeatherForecastDto
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
       .ToArray();
    }
}
