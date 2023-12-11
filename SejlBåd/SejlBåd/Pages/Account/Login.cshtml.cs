using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.AccountServices;

namespace SejlBåd.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty] public Models.Account Account { get; set; }
        private IAccountService _accountService;

        public LoginModel(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPostRegisterAccount()
        {
            Account = _accountService.CreateDummyAccount(Account);

            if (!ModelState.IsValid)
                return Page();

            return RedirectToPage("Register/DateAndCountry", new {Account.Id});
        }
    }
}
