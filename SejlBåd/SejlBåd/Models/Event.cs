using System.ComponentModel.DataAnnotations;

namespace SejlBåd.Models
{
    public class Event
    {
        [Display(Name = "Event Name")]
        [Required(ErrorMessage = "Event needs a name"), MaxLength(100)]
        public string EventName { get; set; }
        [Display(Name = "Event Details")]
        [Required(ErrorMessage = "Event must have a description"), MaxLength(350)]
        public string EventDetails { get; set; }
        [Display(Name = "Event Date")]
        [Required(ErrorMessage = "Event Date cannot be empty")]
        public DateTime EventDate { get; set; }

        public Event(string eventName, string eventDetails, DateTime eventDate)
        {
            EventName = eventName;
            EventDetails = eventDetails;
            EventDate = eventDate;
        }

        public Event()
        {
        }
    }
}
