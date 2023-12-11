using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BoatService;


namespace SejlBåd.Pages.BoatPages
{
    public class RemoveJuniorModel : PageModel
    {
        private Services.BoatService.IBoatService _boatService;
        [BindProperty]
        public Models.JuniorModel juniorModel { get; set; }

        public RemoveJuniorModel(IBoatService BoatService)
        {
            _boatService = BoatService;
        }
        public IActionResult OnGet(int id)
        {
            _boatService = (IBoatService)_boatService.RemoveBoats(id);
            if (juniorModel == null)
            {
                return RedirectToPage("Junior");
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            juniorModel = _boatService.GetJuniorModel(id);
            Models.JuniorModel RemoveJunior = _boatService.RemoveJuniorModel();
            if (RemoveJunior == null)
            {
                return Page();
            }
            _boatService.RemoveJunior(juniorModel);

            return RedirectToPage("/BoatPages/Boats");
        }
    }
}
}
