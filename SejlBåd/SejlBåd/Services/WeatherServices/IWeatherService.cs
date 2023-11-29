using SejlBåd.Models;

namespace SejlBåd.Services.WeatherServices;

public interface IWeatherService
{
    Task<Forecast?> GetTodaysForecast();
}