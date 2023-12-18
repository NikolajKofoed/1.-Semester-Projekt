using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.BoatService;

namespace SejlBåd.Pages.BoatPages
{
    public class LejbådModel : PageModel
    {
        public string Name { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        [BindProperty] Boat Boat { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        IBoatService boatService;

        public LejbådModel(IBoatService boatService)
        {
            this.boatService = boatService;
        }


        public void OnGet(int id)
        {
            
        }


    }
}
