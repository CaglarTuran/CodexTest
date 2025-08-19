using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> GetForecast();
}
