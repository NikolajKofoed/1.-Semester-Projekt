using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.AccountServices;

namespace SejlBåd.Pages.Account.Register
{
    public class DateAndCountryModel : PageModel
    {
        public Models.Account Account { get; set; }
        [BindProperty] public string Country { get; set; }

        [BindProperty] public DateOnly BirthDate { get; set; }

        private IAccountService _accountService;

        public DateAndCountryModel(IAccountService accountService)
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

            _accountService.SetDateAndCountry(Account.Id,BirthDate, Country);
            return RedirectToPage("EmailAndPhoneNum", new { Account.Id });

        }
    }
}
