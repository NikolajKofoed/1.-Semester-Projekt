using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.AccountServices;

namespace SejlBåd.Pages.Account.Register
{
    public class DateAndCountryModel : PageModel
    {
        [BindProperty] public Models.Account Account { get; set; }

        [BindProperty] public DateTime BirthDate { get; set; }

        private IAccountService _accountService;

        public DateAndCountryModel(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            Account = _accountService.CreateDummyAccount(Account);

            if (!ModelState.IsValid)
                return Page();

            _accountService.SetDateAndCountry(Account.Id, BirthDate);
            return RedirectToPage("EmailAndPhoneNum", new { Account.Id });

        }
    }
}
