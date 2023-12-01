using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Repositories;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.EventPages
{
    public class ViewEventsModel : PageModel
    {
        private IMemberService _memberService;
        public Member Member { get; set; }
        public ViewEventsModel(IMemberService memberService)
        {
            _memberService = memberService;
        }
        public void OnGet()
        {
            Member = _memberService.LoggedInMember;
        }
    }
}
