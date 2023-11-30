using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.BoatService;

namespace SejlBåd.Pages.BoatPages
{
    public class GetAllBoatsModel : PageModel
    {
        public IBoatService BoatService;

        public GetAllBoatsModel(IBoatService boatService)
        {
            BoatService = boatService;
        }   

        public void OnGet()
        {
            BoatService.listOfBoats();
        }
    }
}
