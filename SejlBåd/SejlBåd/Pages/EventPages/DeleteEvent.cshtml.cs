using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.EventServices;

namespace SejlBåd.Pages.EventPages
{
    public class DeleteEventModel : PageModel
    {
        private IEventService _eventService;
        [BindProperty]
        public Models.Event Event { get; set; }

        public DeleteEventModel(IEventService eventService)
        {
            _eventService = eventService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _eventService.DeleteEvent(Event.EventId);
            return RedirectToPage("/EventPages/Events");
        }
    }
}