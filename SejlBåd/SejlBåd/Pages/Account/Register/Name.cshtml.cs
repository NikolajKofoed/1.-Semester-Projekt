using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.AccountServices;

namespace SejlBåd.Pages.Account.Register
{
    public class NameModel : PageModel
    {
        public Models.Account Account { get; set; }
        private IAccountService _accountService;

        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }


        public NameModel(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            Account = _accountService.GetDummyAccount(id);

            if (!ModelState.IsValid)
                return Page();

            _accountService.SetName(Account.Id, FirstName, LastName);

            return RedirectToPage("Password", new { Account.Id });

        }
    }
}
