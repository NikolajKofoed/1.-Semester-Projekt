using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.EventPages
{
    public class AddEventModel : PageModel
    {
        private IMemberService _memberService;
        public Member Member { get; set; }
        public AddEventModel(IMemberService memberService)
        {
            _memberService = memberService;
            Member = _memberService.LoggedInMember;
        }
        public void OnGet()
        {
            Member = _memberService.LoggedInMember;
        }
    }
}
