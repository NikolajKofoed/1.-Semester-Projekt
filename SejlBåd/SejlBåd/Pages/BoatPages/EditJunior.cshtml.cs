using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.BoatService;

namespace SejlBåd.Pages.BoatPages
{
    public class EditJuniorModel : PageModel
    {
        private IBoatService _boatService;
        private Boat Boat;

        [BindProperty]
        public Models.Boat boat { get; set; }

        public EditJuniorModel(IBoatService boatService)
        {
            _boatService = boatService;
        }

        public IActionResult OnGet(int id)
        {
            Boat = _boatService.GetBoat(id);
            if (boat == null)
            {
                return RedirectToPage("Index");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _boatService.EditJuniorModel(Boat Boat);
            return RedirectToPage("Boats");
        }
    }
}
}
