using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SejlBåd.Models;
using SejlBåd.Services.EventServices;

namespace SejlBåd.Pages.EventPages
{
    public class EditEventModel : PageModel
    {
        private IEventService _eventService;
        [BindProperty]
        public Models.Event Event { get; set; }

        public EditEventModel(IEventService eventService)
        {
            _eventService = eventService;
        }
        
        public IActionResult OnGet(int id)
        {
            Event = _eventService.GetEvent(id);
            if (Event == null)
            {
                return RedirectToPage("Index");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _eventService.EditEvent(Event);
            return RedirectToPage("Events");
        }
    }
}
