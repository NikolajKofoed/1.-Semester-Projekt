using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.BoatService;

namespace SejlBåd.Pages.BoatPages
{
    public class EditBoatModel : PageModel
    {
        private IBoatService _boatService;

        public Boats Boats { get; set; }

        [BindProperty] public Models.Boat Boat { get; set; }

        public EditBoatModel(IBoatService BoatService)
        {
            _boatService = BoatService;
        }
        public IActionResult OnGet(int id, int id2)
        {
            Boats = _boatService.GetBoats(id);
            Boat = _boatService.GetBoat(id2);

            return Page();
        }

        public IActionResult OnPost(int id)
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            Boats = _boatService.GetBoats(id);

            _boatService.EditBoat(id, Boat);

            return RedirectToPage("Boats", new { Boats.Id });
        }
    }
}

