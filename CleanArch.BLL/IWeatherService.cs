namespace CleanArch.BLL;
public interface IWeatherService
{
    IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays);
}