using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.DockSpotServices;

namespace SejlBåd.Pages.DockSpotPages
{
    public class RentDockSpotModel : PageModel
    {
        private IDockSpotService _dockSpotService;
        [BindProperty] public User Renter { get; set; }
        [BindProperty] public DockSpot DockSpot { get; set; }
        [BindProperty] public DateTime RentPeriodStart { get; set; }
        [BindProperty] public DateTime RentPeriodEnd { get; set; }
        

        public RentDockSpotModel(IDockSpotService dockSpotService)
        {
            _dockSpotService = dockSpotService;
        }


        public IActionResult OnGet(int id)
        {
            DockSpot = _dockSpotService.GetDockSpot(id);
            if( DockSpot == null)
            {
                return RedirectToPage("Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dockSpotService.RentSpot(DockSpot, Renter, RentPeriodStart, RentPeriodEnd);
            return RedirectToPage("ViewDockSpot");
            
        }
    }
}
