using SejlBåd.Models;
using SejlBåd.Models.Dto;

namespace SejlBåd.Services.WeatherServices;

public class WeatherService : IWeatherService
{
    private readonly HttpClient _httpClient;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Forecast?> GetTodaysForecast()
    {
        var response = await _httpClient.GetFromJsonAsync<WeatherForecastDto>("https://api.open-meteo.com/v1/forecast?latitude=55.979448&longitude=12.352958&daily=temperature_2m_min,rain_sum,wind_speed_10m_max,wind_direction_10m_dominant&wind_speed_unit=ms&timezone=Europe%2FBerlin&forecast_days=1");

        if (response != null)
        {
            var forecast = new Forecast()
            {
                Date = response.daily.time[0].ToString(),
                Temperature = response.daily.temperature_2m_min[0].ToString(),
                WindSpeed = response.daily.wind_speed_10m_max[0].ToString(),
                WindDirection = response.daily.wind_direction_10m_dominant[0].ToString(),
                Rain = response.daily.rain_sum[0].ToString(),
            };
            return forecast;
        }
        return null;
    }
}

