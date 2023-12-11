using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.AccountServices;

namespace SejlBåd.Pages.Account.Register
{
    public class PasswordModel : PageModel
    {
        public Models.Account Account { get; set; }
        private IAccountService _accountService;
        [BindProperty]
        public string Password { get; set; }

        public PasswordModel(IAccountService accountService)
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

            _accountService.SetPassword(Account.Id, Password);

            return RedirectToPage("UserName", new { Account.Id });

        }
    }
}
