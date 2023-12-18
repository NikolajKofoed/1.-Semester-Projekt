using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SejlBåd.Models; 
using SejlBåd.Services.BoatService;


namespace SejlBåd.Pages.BoatPages
{
    public class BoatsModel : PageModel
    {
        public IBoatService _BoatService { get; set; }
        public static List<Models.Boat> BoatList { get; set; } = new List<Models.Boat>();
        [BindProperty] public Boat DeleteEvent { get; set; }
        public BoatsModel(IBoatService boatList)
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

            return RedirectToPage("Lejbåd");
        }
    }
}