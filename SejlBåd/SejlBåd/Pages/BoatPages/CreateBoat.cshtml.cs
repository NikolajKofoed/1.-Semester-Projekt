using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BoatService;
using SejlBåd.Services.EventServices;
using System.Reflection;

namespace SejlBåd.Pages.BoatPages
{
    public class CreateBoatModel : PageModel
    {
        private IBoatService _boatservice;
        [BindProperty]
        public Models.Boat Boat { get; set; }
        public CreateBoatModel (IBoatService BoatService)
        {
            _boatservice = BoatService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           _boatservice.AddBoats(Boat); 
            return RedirectToPage("Boats");
        }
    }
}
