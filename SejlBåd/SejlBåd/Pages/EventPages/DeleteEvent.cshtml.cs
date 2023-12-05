using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using SejlBåd.Services.EventServices;

namespace SejlBåd.Pages.EventPages
{
    public class DeleteEventModel : PageModel
    {
        private IEventService _eventService;
        [BindProperty]
        public Models.Event events { get; set; }

        public DeleteEventModel(IEventService eventService)
        {
            _eventService = eventService;
        }
        public IActionResult OnGet(int id)
        {
            events = _eventService.GetEvent(id);
            if(events == null)
            {
                return RedirectToPage("Events");
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _eventService.DeleteEvent(events.EventId);
            
          return RedirectToPage("Events");
        }
    }
}