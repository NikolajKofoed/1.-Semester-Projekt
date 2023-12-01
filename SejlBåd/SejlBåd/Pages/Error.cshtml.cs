using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.MemberServices;
using System.Diagnostics;

namespace SejlBåd.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorModel> _logger;
        public Member Member { get; set; }
        private IMemberService _memberService;

        public ErrorModel(ILogger<ErrorModel> logger, IMemberService memberService)
        {
            _logger = logger;
            _memberService = memberService;
        }

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            Member = _memberService.LoggedInMember;
        }
    }
}