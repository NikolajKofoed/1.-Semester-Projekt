using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SejlBåd.Models; 
using SejlBåd.Services.BoatService;

namespace SejlBåd.Pages.BoatPages
{
    public class BoatsModel : PageModel
    {
        public IBoatService _boatService { get; set; }
        public List<Boat> BoatList { get; set; }
        public Boats Boats { get; set; }


        public BoatsModel(IBoatService boatList)
        {
            _boatService = boatList;
        }
        public IActionResult OnGet(int id)
        {
            Boats = _boatService.GetBoats(id);
            BoatList = _boatService.GetBoatList(id);

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