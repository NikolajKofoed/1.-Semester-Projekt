using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.MemberServices;
using SejlBåd.Models;

namespace SejlBåd.Pages.MemberPages
{
    public class AccountModel : PageModel
    {
        private IMemberService _memberService;
        public Member Member { get; set; }

        public AccountModel(IMemberService memberService)
        {
            _memberService = memberService;
            Member = _memberService.GetMember(LoginPageModel.LoggedInMember.UserId);
        }
        public void OnGet()
        {
        }
    }
}
