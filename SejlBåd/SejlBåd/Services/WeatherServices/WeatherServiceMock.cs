using SejlBåd.Models;

namespace SejlBåd.Services.WeatherServices;

public class WeatherServiceMock : IWeatherService
{
    public WeatherServiceMock()
    { }

    public Task<Forecast?> GetTodaysForecast()
    {
        var mockForecast = new Forecast()
        {
            Date = DateTime.Now.ToString("dd-MM-yyyy"),
            Temperature = Random.Shared.Next(-20, 30).ToString(),
            WindSpeed = Random.Shared.Next(0, 30).ToString(),
            WindDirection = Random.Shared.Next(0, 360).ToString(),
            Rain = Random.Shared.Next(0, 100).ToString()
        };

        return Task.FromResult(mockForecast);
    }
}