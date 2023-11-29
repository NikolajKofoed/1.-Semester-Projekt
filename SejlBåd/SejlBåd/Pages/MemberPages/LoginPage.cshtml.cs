using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.MemberPages
{
    public class LoginPageModel : PageModel
    {
        private IMemberService _memberService;

        [BindProperty] public string UserName { get; set; }
        [BindProperty] public string Password { get; set; }

        public LoginPageModel(IMemberService memberService)
        {
            _memberService = memberService;
        }


        public IActionResult OnGet()
        {
            return Page();
        }


        public IActionResult OnPost()
        {

            if(!_memberService.Login(UserName, Password))
            {
                return Page();
            }

            return RedirectToPage("CreateAccount");
        }
    }
}
