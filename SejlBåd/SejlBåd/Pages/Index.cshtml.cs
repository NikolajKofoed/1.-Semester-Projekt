using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.WeatherServices;

namespace SejlBåd.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    private readonly IWeatherService _weatherService;


    public Forecast TodaysForecast { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IWeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    public async Task OnGet()
    {
        TodaysForecast = await _weatherService.GetTodaysForecast();
    }
}