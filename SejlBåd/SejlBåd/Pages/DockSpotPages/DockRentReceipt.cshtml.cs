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
        private IDockSpotService _dockSpotService;
        private IOrderService _orderService;
        private ICustomerService _customerService;
        [BindProperty] public User Order { get; set; }

        public DockRentReceiptModel(IDockSpotService dockSpotService, IOrderService orderService, ICustomerService customerService)
        {
            _orderService = orderService;
            _dockSpotService = dockSpotService;
            _customerService = customerService;
        }
        public IActionResult OnGet(string email)
        {
            Order = _customerService.CheckForExistingUser(email);
            return Page();
        }
    }
}
