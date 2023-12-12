using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BoatService;


namespace SejlBåd.Pages.BoatPages
{
    public class DeleteJuniorModel : PageModel
    {
        private Services.BoatService.IBoatService _boatService;
        [BindProperty]
        public Models.JuniorBoat juniorModel { get; set; }

        public DeleteJuniorModel(IBoatService BoatService)
        {
            _boatService = BoatService;
        }
        public IActionResult OnGet(int id)
        {
            _boatService = (IBoatService)_boatService.DeleteBoats(id);
            if (juniorModel == null)
            {
                return RedirectToPage("Junior");
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            juniorModel = _boatService.GetJuniorModel(id);
            Models.JuniorBoat DeleteJunior = _boatService.DeleteJuniorModel();
            if (DeleteJunior == null)
            {
                return Page();
            }
            _boatService.DeleteJunior(juniorModel);

            return RedirectToPage("/BoatPages/Boats");
        }
    }
}