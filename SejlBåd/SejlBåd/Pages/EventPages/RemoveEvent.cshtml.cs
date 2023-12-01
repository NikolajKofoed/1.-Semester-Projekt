using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.EventPages
{
    public class RemoveEventModel : PageModel
    {
        private IMemberService _memberService;
        public Member Member { get; set; }
        public RemoveEventModel(IMemberService memberService)
        {
            _memberService = memberService;
        }
        public void OnGet()
        {
            Member = _memberService.LoggedInMember;
        }
    }
}
