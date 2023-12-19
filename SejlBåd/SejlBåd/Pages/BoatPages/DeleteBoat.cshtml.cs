using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BoatService;
using SejlBåd.Models;


namespace SejlBåd.Pages.BoatPages
{
    public class DeleteBoatModel : PageModel
    {
        private Services.BoatService.IBoatService _boatService;
        [BindProperty]
        public Boat Boat { get; set; }

        public Boats Boats { get; set; }

        public DeleteBoatModel(IBoatService BoatService)
        {
            _boatService = BoatService;
        }
        public IActionResult OnGet(int id, int id2)
        {
            Boats = _boatService.GetBoats(id);
            Boat = _boatService.GetBoat(id2);
            
            return Page();
        }

        public IActionResult OnPost(int id, int id2)
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            Boats = _boatService.GetBoats(id);
            Boat = _boatService.GetBoat(id2);

            _boatService.DeleteBoat(id, Boat);

            return RedirectToPage("Boats", new {Boats.Id});
        }
    }
}