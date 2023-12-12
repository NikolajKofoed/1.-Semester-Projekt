using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.AccountServices;

namespace SejlBåd.Pages.Account.Register
{
    public class EmailAndPhoneNumModel : PageModel
    {
        public Models.Account Account { get; set; }
        private IAccountService _accountService;
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string PhoneNum { get; set; }

        public EmailAndPhoneNumModel(IAccountService accountService)
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

            _accountService.SetEmailAndPhoneNum(Account.Id, Email, PhoneNum);

            return RedirectToPage("Name", new { Account.Id });

        }
    }
}
