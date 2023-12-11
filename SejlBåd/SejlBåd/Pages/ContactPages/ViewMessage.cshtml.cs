using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.ContactService;

namespace SejlBåd.Pages.ContactPages
{
    public class ViewMessageModel : PageModel
    {
        public IContactService ContactService { get; set; }
        [BindProperty] public Contact contacts { get; set; }

        public ViewMessageModel(IContactService contactService) 
        {
            ContactService = contactService;
        }

        public void OnGet(int Id)
        {
            contacts = ContactService.ViewMessage(Id);
        }
    }
}
