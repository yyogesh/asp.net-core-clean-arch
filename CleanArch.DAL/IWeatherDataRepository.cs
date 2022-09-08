namespace CleanArch.DAL;
public interface IWeatherDataRepository
{
    IEnumerable<WeatherForecastDto> Get(string cityName, int numberOfDays);
}