using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.ContactService;

namespace SejlBåd.Pages.ContactPages
{
    public class DeleteMessageModel : PageModel
    {
        private IContactService _contactService;
        [BindProperty]
        public Contact ContactList { get; set; }

        public DeleteMessageModel(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult OnGet(int Id)
        {
            ContactList = _contactService.ViewMessage(Id);
            if (ContactList == null)
            {
                return RedirectToPage("GetAllMessages");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            Contact deletedMessage = _contactService.DeleteMessage(ContactList.Id);
            return RedirectToPage("GetAllMessages");
        }
    }
}
