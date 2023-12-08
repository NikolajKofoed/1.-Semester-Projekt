using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.CustomerServices;
using SejlBåd.Services.DockSpotServices;
using SejlBåd.Services.OrderServices;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SejlBåd.Pages.DockSpotPages
{
    public class RentDockSpotExistingCustomerModel : PageModel
    {
        public ICustomerService _customerService;
        private IDockSpotService _dockSpotService;
        private IOrderService _orderService;
        
        public User Customer { get; set; }
        [Required(ErrorMessage = "angiv en mail")]
        [BindProperty] public string CustomerEmail { get; set; }
        public DockSpot DockSpot { get; set; }


        public RentDockSpotExistingCustomerModel(ICustomerService customerService, IDockSpotService dockSpotService, IOrderService orderService)
        {
            _customerService = customerService;
            _dockSpotService = dockSpotService;
            _orderService = orderService;
        }
        public IActionResult OnGet()
        {
            // if there are no more dockspots available redirect to another page
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

            // if email doesn't exists return page
            if (_customerService.CheckForExistingUser(CustomerEmail) != null)
            {
                Customer = _customerService.CheckForExistingUser(CustomerEmail);
            }
            else
            {

                return Page();
            }

            DockSpot = _dockSpotService.GetNextAvailableDockSpot();


            // rent boat and create save order
            _dockSpotService.RentSpot(Customer, DockSpot.Id);
            _orderService.CreateOrderDockSpot(DockSpot, Customer);

            return RedirectToPage("DockRentReceipt");
            
        }
    }
}
