using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Repositories;

namespace SejlBåd.Pages.EventPages
{
    public class AddEventModel : PageModel
    {
        EventRepository eventRepository = new EventRepository();

        public AddEventModel( )
        {
        }
        public void OnGet()
        {
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

            string eventName = Request.Form["eventName"];
            string eventDetails = Request.Form["eventDetails"];
            string eventDate = Request.Form["eventDate"];

            DateTime ConvertedEventDate = DateTime.Parse(eventDate);

            eventRepository.AddEvent(eventName, eventDetails, ConvertedEventDate);
        }
    }
}
