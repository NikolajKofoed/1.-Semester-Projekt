using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.BoatService;

namespace SejlBåd.Pages.BoatPages
{
    public class EditBoatModel : PageModel
    {
        private IBoatService _boatService;
        private Boat Boat;

        [BindProperty] public Models.Boat boat { get; set; }

        public EditBoatModel(IBoatService boatService)
        {
            _boatService = boatService;
        }

        public IActionResult OnGet(int id)
        {
            Boat = _boatService.GetBoat(id);
            if (boat == null)
            {
                return RedirectToPage("/BoatPages/GetAllBoats");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _boatService.EditBoat(Boat);
            return RedirectToPage("/BoatPages/GetAllBoats");
        }
    }
}

