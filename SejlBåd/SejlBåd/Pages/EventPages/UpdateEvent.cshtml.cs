using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Repositories;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.EventPages
{
    public class UpdateEventModel : PageModel
    {
        [BindProperty] public Event Event { get; set; }
        private IMemberService _memberService;
        public Member Member { get; set; }
        public UpdateEventModel(IMemberService memberService)
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
