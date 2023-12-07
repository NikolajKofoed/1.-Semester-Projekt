using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.CustomerServices;
using SejlBåd.Services.DockSpotServices;
using SejlBåd.Services.OrderServices;

namespace SejlBåd.Pages.DockSpotPages
{
    public class RentDockSpotModel : PageModel
    {
        private IDockSpotService _dockSpotService;
        private IOrderService _orderService;
        private ICustomerService _customerService;
        [BindProperty] public DockSpot DockSpot { get; set; }
        [BindProperty] public User Customer { get; set; }

        public RentDockSpotModel(IDockSpotService dockSpotService, IOrderService orderService, ICustomerService customerService)
        {
            _orderService = orderService;
            _dockSpotService = dockSpotService;
            _customerService = customerService;
        }


        public IActionResult OnGet()
        {
            if (_dockSpotService.GetNextAvailableDockSpot() == null)
                return RedirectToPage("TestPage");

            return Page();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(_customerService.CheckForExistingUser(Customer.Email) == null)
            {
                _customerService.CreateUser(Customer);
            }
            else
            {
                // give feedback
            }
            // need to set dockspot again here or it will get always be set to dockspot with id 1
            DockSpot = _dockSpotService.GetNextAvailableDockSpot();

            _dockSpotService.RentSpot(Customer, DockSpot.Id);

            _orderService.CreateOrderDockSpot(DockSpot, Customer);

            return RedirectToPage("DockRentReceipt");
            
        }
    }
}
