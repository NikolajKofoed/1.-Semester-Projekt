using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private IMemberService _memberService;
        public Member Member { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger, IMemberService memberService)
        {
            _logger = logger;
            _memberService = memberService;
        }

        public void OnGet()
        {
            Member = _memberService.LoggedInMember;
        }
    }
}