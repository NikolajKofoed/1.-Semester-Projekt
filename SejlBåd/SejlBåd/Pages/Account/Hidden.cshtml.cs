using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.AccountServices;

namespace SejlBåd.Pages.Account
{
    public class HiddenModel : PageModel
    {
        private IAccountService _accountService;
        public HiddenModel(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult OnGet()
        {
            var userRole = HttpContext.Session.GetString("UserRole");

            if(string.IsNullOrEmpty(userRole))
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
