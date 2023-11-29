using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.MemberPages
{
    public class CreateAccountModel : PageModel
    {
        [BindProperty] public Member Member { get; set; }
        private IMemberService _memberService;

        public CreateAccountModel(IMemberService memberService)
        {
            _memberService = memberService;
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // set the unique userId
            // todo: make it unique
            Member.UserId = (Member.UserIdString+ "#" + Member.UserIdNum).ToString();
            //add member
            _memberService.AddMember(Member);
            return RedirectToPage("LoginPage");
        }
    }
}
