using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BoatService;


namespace SejlBåd.Pages.BoatPages
{
    public class DeleteBoatModel : PageModel
    {
        private Services.BoatService.IBoatService _boatService;
        [BindProperty]
        public Models.Boat Boat { get; set; }

        public DeleteBoatModel(IBoatService BoatService)
        {
            _boatService = BoatService;
        }
        public IActionResult OnGet(int id)
        {
            Boat = _boatService.GetBoat(id);
            
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            Boat = _boatService.GetBoat(id);
            Models.Boat DeleteBoat = _boatService.DeleteBoat(id);
            if (DeleteBoat == null)
            {
                return Page();
            }
            _boatService.DeleteBoat(id);

            return RedirectToPage("Boats");
        }
    }
}