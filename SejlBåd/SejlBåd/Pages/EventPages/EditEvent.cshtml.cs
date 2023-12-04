using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.EventServices;

namespace SejlBåd.Pages.EventPages
{
    public class EditEventModel : PageModel
    {
        private IEventService eventService;
        public void OnGet()
        {
        }
    }
}
