using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BoatService;


namespace SejlBåd.Pages.BoatPages
{
    public class DeleteJuniorModel : PageModel
    {
        private Services.BoatService.IBoatService _boatService;
        [BindProperty]
        public Models.JuniorModel juniorModel { get; set; }

        public DeleteJuniorModel(IBoatService BoatService)
        {
            _boatService = BoatService;
        }
        public IActionResult OnGet(int id)
        {
            _boatService = (IBoatService)_boatService.GetjuniorModel(id);
            if (juniorModel == null)
            {
                return RedirectToPage("Junior");
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            juniorModel = _boatService.GetjuniorModel(id);
            Models.Junior deletedJunior = _boatService.DeleteJunior(Id);
            if (deletedJunior == null)
            {
                return Page();
            }
            _boatService.DeleteJunior(JuniorModel.Id);

            return RedirectToPage("Junior");
        }
    }
}
}
