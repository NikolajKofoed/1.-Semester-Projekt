using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.EventServices;

namespace SejlBåd.Pages.EventPages
{
    public class EventsModel : PageModel
    {
        public IEventService _eventService { get; set; }
        public static List<Event> Events { get; set; }
        [BindProperty] public Event DeleteEvent { get; set; }
        public EventsModel(IEventService eventService)
        {
            _eventService = eventService;
        }
        public IActionResult OnGet()
        {
            Events = _eventService.GetEvents();

            if (Events == null)
            {
                return RedirectToPage("/index");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return Page();
        }
    }
}
