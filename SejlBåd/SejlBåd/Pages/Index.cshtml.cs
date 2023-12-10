using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.DockSpotServices;
using SejlBåd.Services.WeatherServices;

namespace SejlBåd.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    private readonly IWeatherService _weatherService;

    private IDockSpotService _dockSpotService;

    private LinkGenerator _linkGenerator;

    public Forecast TodaysForecast { get; set; }
    public string PathByPage { get; set; }

    [BindProperty] public DockSpot DockSpot { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IWeatherService weatherService, IDockSpotService dockSpotService, LinkGenerator linkGenerator)
    {
        _logger = logger;
        _weatherService = weatherService;
        _dockSpotService = dockSpotService;
        _linkGenerator = linkGenerator;
    }

    public async Task OnGet()
    {
        TodaysForecast = await _weatherService.GetTodaysForecast();
    }

}