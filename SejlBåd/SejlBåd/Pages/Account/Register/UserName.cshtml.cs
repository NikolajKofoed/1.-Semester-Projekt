using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.AccountServices;

namespace SejlBåd.Pages.Account.Register
{
    public class UserNameModel : PageModel
    {
        [BindProperty] public Models.Account Account { get; set; }
        private IAccountService _accountService;

        [BindProperty]
        public string UserName { get; set; }

        public UserNameModel(IAccountService accountService)
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


            _accountService.SetUserName(Account.Id, UserName);
            _accountService.CreateAccount(Account);
            return RedirectToPage("AccountCreatedNotice", new { Account.Id });

        }
    }
}
