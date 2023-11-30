using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.MemberPages
{
    public class LoginPageModel : PageModel
    {
        private IMemberService _memberService;
        [BindProperty] public string? UserName { get; set; }
        [BindProperty] public string? Password { get; set; }
        public static Member? LoggedInMember { get; set; }

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
            // if login attempt isn't success full, do nothing(maybe give some indikation)
            if(_memberService.Login(UserName, Password) == null)
            {
                return Page();
            }

            //the account link in the nav bar should now have the members username, and new options when hovering it

            // sets the member to a local variable which we can use to change and view information
            LoggedInMember = _memberService.Login(UserName, Password);
            return RedirectToPage("TestSite");
        }
    }
}
