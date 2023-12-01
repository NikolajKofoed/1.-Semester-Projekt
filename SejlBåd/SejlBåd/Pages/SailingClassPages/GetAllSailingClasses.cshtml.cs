using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.SailingClassPages
{
    public class GetAllSailingClassesModel : PageModel
    {
        private IMemberService _memberService;
        public Member Member { get; set; }
        public List<Models.SailingClass> sailingClasses { get; private set; }

        [BindProperty] public string ClassName { get; set; }

        public GetAllSailingClassesModel(IMemberService memberService)
        {
            _memberService = memberService;
        }
        public void OnGet()
        {
            Member = _memberService.LoggedInMember;
        }
    }
}
