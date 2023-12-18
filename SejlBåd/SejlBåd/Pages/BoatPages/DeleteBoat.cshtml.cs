using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BoatService;


namespace SejlBåd.Pages.BoatPages
{
    public class DeleteBoatModel : PageModel
    {
        private Services.BoatService.IBoatService _boatService;
        [BindProperty]
        public Models.JuniorBoat juniorModel { get; set; }

        public DeleteBoatModel(IBoatService BoatService)
        {
            _boatService = BoatService;
        }
        public IActionResult OnGet(int id)
        {
            if (juniorModel == null)
            {
                return RedirectToPage("Junior");
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            juniorModel = _boatService.GetBoatModel(id);
            Models.BoatBoat DeleteJunior = _boatService.DeleteBoatModel();
            if (DeleteJunior == null)
            {
                return Page();
            }
            _boatService.DeleteBoat(BoatModel);

            return RedirectToPage("/BoatPages/Boats");
        }
    }
}