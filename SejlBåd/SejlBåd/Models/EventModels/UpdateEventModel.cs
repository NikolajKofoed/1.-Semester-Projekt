using Microsoft.AspNetCore.Mvc;
using SejlBåd.Repositories;

namespace SejlBåd.Models.EventModels
{
    public class UpdateEventModel
    {
        private readonly EventRepository _eventRepository;

        [BindProperty]
        public string EventName { get; set; }

        [BindProperty]
        public string EventDetails { get; set; }

        [BindProperty]
        public string EventDate { get; set; }

        public UpdateEventModel(EventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public void OnGet(string eventName)
        {
            var eventDetails = _eventRepository.GetEventByName(eventName);

            if (eventDetails == null)
            {
                // Handle the case where the event is not found
                return;
            }

            EventName = eventDetails.EventName;
            EventDetails = eventDetails.EventDetails;
            EventDate = eventDetails.EventDate;
        }
    }
}
