using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.AccountServices;
using SejlBåd.Services.BoatService;

namespace SejlBåd.Pages.BoatPages
{
    public class LejbådModel : PageModel
    {

        IBoatService _boatService;
        IAccountService _accountService;

        [BindProperty]
        public Models.Account Account { get; set; }
        public Boat Boat { get; set; }
        [BindProperty]public string UserName { get; set; }
        [BindProperty]public string Password { get; set; }

        public LejbådModel(IBoatService boatService, IAccountService accountService)
        {
            _accountService = accountService;
            _boatService = boatService;
        }

        public IActionResult OnGet(int id2)
        {

            Boat = _boatService.GetBoat(id2);

            return Page();

        }

        public IActionResult OnPost(int id, int id2)
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            if(_accountService.Login(UserName, Password) != null)
            {
                Account = _accountService.Login(UserName, Password);
            }
            else
            {
                return Page();
            }
            Boat = _boatService.GetBoat(id2);
            _boatService.RentBoat(id, Boat, Account);
            return RedirectToPage("Boats", new { id });

        }


    }
}
