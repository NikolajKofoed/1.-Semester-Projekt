using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.CustomerServices;
using SejlBåd.Services.DockSpotServices;
using SejlBåd.Services.OrderServices;

namespace SejlBåd.Pages.DockSpotPages
{
    public class DockRentReceiptModel : PageModel
    {
        private IOrderService _orderService;
        [BindProperty] public Order Order { get; set; }

        public DockRentReceiptModel(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult OnGet(string email)
        {
            //inconsistent way of doing, should be changed when possible
            Order = _orderService.GetLatestOrder();
            return Page();
        }
    }
}
