using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.MemberServices;
using SejlBåd.Services.WeatherServices;

namespace SejlBåd.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    private readonly IWeatherService _weatherService;
    private IMemberService _memberService;
    public Member Member { get; set; }

    public Forecast TodaysForecast { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IWeatherService weatherService, IMemberService memberService)
    {
        _logger = logger;
        _weatherService = weatherService;
        _memberService = memberService;
    }

    public async Task OnGet()
    {
        TodaysForecast = await _weatherService.GetTodaysForecast();
        Member = _memberService.LoggedInMember;
    }
}