using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.DockSpotServices;

namespace SejlBåd.Pages.DockSpotPages
{
    public class ViewDockSpotModel : PageModel
    {
        public IDockSpotService _dockSpotService;
        public static DockSpot[] DockSpots { get; set; }

        public ViewDockSpotModel(IDockSpotService dockSpotService)
        {
            _dockSpotService = dockSpotService;
        }
        public void OnGet()
        {
            DockSpots = _dockSpotService.GetDockSpots();
        }
    }
}
