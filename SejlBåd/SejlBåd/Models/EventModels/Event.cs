using Microsoft.AspNetCore.Mvc;
using SejlBåd.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SejlBåd.Models.EventModels
{
    public class Event
    {
        private readonly EventRepository _eventRepository;

        [BindProperty]
        [Display(Name = "Event Name")]
        [Required(ErrorMessage = "Event needs a name"), MaxLength(100)]
        public string EventName { get; set; }

        [BindProperty]
        [Display(Name = "Event Details")]
        [Required(ErrorMessage = "Event must have a description"), MaxLength(350)]
        public string EventDetails { get; set; }

        [BindProperty]
        [Display(Name = "Event Date")]
        [Required(ErrorMessage = "Event Date cannot be empty")]
        public string EventDate { get; set; }

        public Event(EventRepository eventRepository)
        {
            _eventRepository = eventRepository;
            EventName = "et eller andet";

        }

        public void OnGet(string eventName)
        {
            var eventDetails = _eventRepository.GetEventByName(eventName);

            EventName = eventDetails.EventName;
            EventDetails = eventDetails.EventDetails;
            EventDate = eventDetails.EventDate;
        }
    }
}
