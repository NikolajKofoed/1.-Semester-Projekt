using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.BoatService;
using SejlBåd.Services.EventServices;
using System.Reflection;

namespace SejlBåd.Pages.BoatPages
{
    public class CreateBoatModel : PageModel
    {
        private IBoatService _boatService;
        [BindProperty]
        public Models.Boat Boat { get; set; }
        public Boats Boats { get; set; }
        public CreateBoatModel (IBoatService BoatService)
        {
            _boatService = BoatService;
        }
        public IActionResult OnGet(int id)
        {
            Boats = _boatService.GetBoats(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Boats = _boatService.GetBoats(id);

            _boatService.AddBoats(id, Boat); 
            return RedirectToPage("Boats", new {Boats.Id});
        }
    }
}
