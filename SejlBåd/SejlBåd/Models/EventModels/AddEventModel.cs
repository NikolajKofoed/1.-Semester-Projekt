using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SejlBåd.Models.EventModels
{
    public class AddEventModel : PageModel
    {
        private readonly EventRepository _eventRepository;

        public AddEventModel(EventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        [BindProperty]
        [Display(Name = "Event Name")]
        [Required(ErrorMessage = "Event needs a name"), MaxLength(100)]
        public string EventName { get; set; }

        [BindProperty]
        [Display(Name = "Event Details")]
        [Required(ErrorMessage = "Event must have a description"), MaxLength(350)]
        public string EventDescription { get; set; }

        [BindProperty]
        [Display(Name = "Event Date")]
        [Required(ErrorMessage = "Event Date cannot be empty")]
        public DateTime EventDate { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Call the AddEvent method from the repository
            _eventRepository.AddEvent(EventName, EventDescription, EventDate);

            return RedirectToPage("/Index");
        }
    }
}