using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.EventServices;

namespace SejlBåd.Pages.EventPages
{
    public class CreateEventModel : PageModel
    {
        private IEventService _eventservice;
        [BindProperty]
        public Models.Event Event { get; set; }
        public CreateEventModel(IEventService eventService)
        {
            _eventservice = eventService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        { 
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _eventservice.CreateEvent(Event);
            return RedirectToPage("/EventPages/Events");
        }
    }
}
