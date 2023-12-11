using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Services.ContactService;

namespace SejlBåd.Pages.ContactPages
{
    public class CreateNewMessageModel : PageModel
    {
        private IContactService _contactService;
        [BindProperty]
        public Models.Contact Contact { get; set; }

        public CreateNewMessageModel(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPostMessage()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _contactService.AddMessage(Contact);
            return RedirectToPage("/ContactPages/ThankYouMessage");
        }
    }
}
