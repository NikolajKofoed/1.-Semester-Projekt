using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.AccountServices;

namespace SejlBåd.Pages.Account.Register
{
    public class AccountCreatedNoticeModel : PageModel
    {
        public Models.Account Account { get; set; }
        private IAccountService _accountService;

        public AccountCreatedNoticeModel(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public void OnGet(int id)
        {
            Account = _accountService.GetDummyAccount(id);
        }
    }
}
