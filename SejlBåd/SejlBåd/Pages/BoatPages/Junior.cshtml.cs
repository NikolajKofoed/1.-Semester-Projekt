using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SejlBåd.Models; 
using SejlBåd.Services.BoatService;


namespace SejlBåd.Pages.BoatPages
{
    public class JuniorModel : PageModel
    {
        public IBoatService _BoatService { get; set; }
        public static List<Models.Boat> BoatList { get; set; } = new List<Models.Boat>();
        [BindProperty] public Boat DeleteEvent { get; set; }
        public JuniorModel(IBoatService boatList)
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