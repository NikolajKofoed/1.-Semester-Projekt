using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SejlBåd.Models; 
using SejlBåd.Services.BoatService;
using SejlBåd.Services.BoatService.BoatListService;

namespace SejlBåd.Pages.BoatPages
{
    public class BoatsModel : PageModel
    {
        public IBoatService _BoatService { get; set; }
        public IBoatListService _boatListService;
        public static List<Boat> BoatList { get; set; }


        public BoatsModel(IBoatService boatList, IBoatListService boatListService)
        {
            _boatListService = boatListService;
            _BoatService = boatList;
        }
        public IActionResult OnGet(int id)
        {
            BoatList = _boatListService.GetBoatList(id);

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