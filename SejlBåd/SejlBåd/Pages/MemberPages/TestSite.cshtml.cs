using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.MemberPages
{
    public class TestSiteModel : PageModel
    {
        public Member Member { get; set; }
        private IMemberService _memberService;
        public TestSiteModel(IMemberService memberService)
        {
            _memberService = memberService;
        }
        public void OnGet()
        {
            Member = _memberService.LoggedInMember;
        }
    }
}
