using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.DockSpotServices;
using SejlBåd.Services.OrderServices;

namespace SejlBåd.Pages.DockSpotPages
{
    public class RentDockSpotModel : PageModel
    {
        private IDockSpotService _dockSpotService;
        private IOrderService _orderService;
        [BindProperty] public Order Order { get; set; }
        public DockSpot DockSpot { get; set; }

        public RentDockSpotModel(IDockSpotService dockSpotService, IOrderService orderService)
        {
            _orderService = orderService;
            _dockSpotService = dockSpotService;
        }


        public IActionResult OnGet()
        {
            return Page();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _dockSpotService.RentSpot(Order.Customer);
            
            _orderService.CreateOrder(Order);

            return RedirectToPage("DockRentReceipt");
            
        }
    }
}
