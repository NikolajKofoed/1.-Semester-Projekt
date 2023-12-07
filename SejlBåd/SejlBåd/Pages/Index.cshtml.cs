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

    public Forecast TodaysForecast { get; set; }

    [BindProperty] public DockSpot DockSpot { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IWeatherService weatherService, IDockSpotService dockSpotService)
    {
        _logger = logger;
        _weatherService = weatherService;
        _dockSpotService = dockSpotService;
    }

    public async Task OnGet()
    {
        TodaysForecast = await _weatherService.GetTodaysForecast();
    }

    public IActionResult OnPostCheckDockSpot()
    {
        if(_dockSpotService.CheckDogSpots() == null)
        return Page();

        DockSpot = _dockSpotService.CheckDogSpots();
        return RedirectToPage(@"DockSpotPages/RentDockSpot/{DockSpot.Id}");

        

    }
}