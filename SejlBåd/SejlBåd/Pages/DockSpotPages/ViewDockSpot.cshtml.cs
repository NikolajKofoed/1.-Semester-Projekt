using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.DockSpotServices;
using SejlBåd.Services.OrderServices;

namespace SejlBåd.Pages.DockSpotPages
{
    public class ViewDockSpotModel : PageModel
    {
        public IDockSpotService _dockSpotService;
        private IOrderService _orderService;
        public static DockSpot[] DockSpots { get; set; }

        public ViewDockSpotModel(IDockSpotService dockSpotService, IOrderService orderService)
        {
            _dockSpotService = dockSpotService;
            _orderService = orderService;
        }
        public IActionResult OnGet()
        {
            var userRole = HttpContext.Session.GetString("UserRole");

            if (string.IsNullOrEmpty(userRole) || userRole != "Admin")
            {
                return RedirectToPage("/AuthenticationFailed");
            }
            DockSpots = _dockSpotService.GetDockSpots();
            return Page();
        }
    }
}
