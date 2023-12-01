using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.BoatService;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.BoatPages
{
    public class GetAllBoatsModel : PageModel
    {
        public IBoatService BoatService;
        private IMemberService _memberService;
        public Member Member { get; set; }

        public GetAllBoatsModel(IBoatService boatService, IMemberService memberService)
        {
            BoatService = boatService;
            _memberService = memberService;
        }   

        public void OnGet()
        {
            BoatService.listOfBoats();
            Member = _memberService.LoggedInMember;
        }
    }
}
