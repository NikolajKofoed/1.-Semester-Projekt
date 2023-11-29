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
            // if login attempt isn't success full, do nothing
            if(!_memberService.Login(UserName, Password))
            {
                return Page();
            }

            //should give you authority of the account you logged into(

            return RedirectToPage("/Pages/Index");
        }
    }
}
