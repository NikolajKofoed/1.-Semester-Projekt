using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.AccountServices;

namespace SejlBåd.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty] public Models.Account Account { get; set; }
        private IAccountService _accountService;
        [BindProperty]
        public string UserName { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public LoginModel(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult OnGet()
        {
            var userRole = HttpContext.Session.GetString("UserRole");

            if (userRole == "User" || userRole == "Admin")
            {
                return RedirectToPage("/AuthenticationFailed");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            Account = _accountService.Login(UserName, Password);

            if (Account != null)
            {
                // Store user role in session or authentication cookie
                HttpContext.Session.SetString("UserRole", Account.Role);
            }
            
            return RedirectToPage("/Index", new { Account.Id });

        }

    }
}
