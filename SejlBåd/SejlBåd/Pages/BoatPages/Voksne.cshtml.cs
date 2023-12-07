using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.BoatService;

namespace SejlBåd.Pages.BoatPages
{
    public class VoksneModel : PageModel
    {
        public IBoatService _BoatService { get; set; }
        public static List<Models.Boat> BoatList { get; set; } = new List<Models.Boat>();
        [BindProperty] public Boat DeleteEvent { get; set; }
        public VoksneModel(IBoatService boatList)
        {
            _BoatService = boatList;
        }
        public IActionResult OnGet()
        {
            BoatList = _BoatService.listOfBoats();

            if (BoatList == null)
            {
                return RedirectToPage("/index");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return Page();
        }
    }
}
