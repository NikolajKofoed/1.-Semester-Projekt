using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Repositories;
using SejlBåd.Services.MemberServices;

namespace SejlBåd.Pages.EventPages
{
    public class AddEventModel : PageModel
    {
        private IMemberService _memberService;
        public Member Member { get; set; }
        EventRepository eventRepository = new EventRepository();

        public AddEventModel(IMemberService memberService)
        {
            _memberService = memberService;
            Member = _memberService.LoggedInMember;
        }
        public void OnGet()
        {
            Member = _memberService.LoggedInMember;
        }

        //public void AddEvent(string eventName, string eventDetails, DateTime eventDate)
        //{
        //    if(!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
        //    eventRepository.Add(new Models.Event { EventName = eventName, EventDetails = eventDetails, EventDate = eventDate });
        //}

        public void OnPost()
        {
            Member = _memberService.LoggedInMember;

            string eventName = Request.Form["eventName"];
            string eventDetails = Request.Form["eventDetails"];
            string eventDate = Request.Form["eventDate"];

            DateTime ConvertedEventDate = DateTime.Parse(eventDate);

            eventRepository.AddEvent(eventName, eventDetails, ConvertedEventDate);
        }
    }
}
