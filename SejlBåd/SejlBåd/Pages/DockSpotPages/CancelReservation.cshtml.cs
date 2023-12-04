using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.DockSpotServices;

namespace SejlBåd.Pages.DockSpotPages
{
    
    public class CancelReservationModel : PageModel
    {
        IDockSpotService _dockSpotService;
        [BindProperty] public DockSpot DockSpot { get; set; }

        public CancelReservationModel(IDockSpotService dockSpotService)
        {
            _dockSpotService = dockSpotService;
        }
        public IActionResult OnGet(int id)
        {
            DockSpot = _dockSpotService.GetDockSpot(id);
            if(DockSpot == null)
            {
                return RedirectToPage("Pages/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dockSpotService.CancelReservation(DockSpot);
            return RedirectToPage("ViewDockSpot");

        }
    }
}
