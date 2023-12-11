using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SejlBåd.Models;
using SejlBåd.Services.ContactService;

namespace SejlBåd.Pages.ContactPages
{
    public class GetAllMessagesModel : PageModel
    {
        public IContactService ContactService { get; set; }
        public List<Contact> contactMessages { get; set; }

        public GetAllMessagesModel(IContactService contactService) 
        { 
            this.ContactService = contactService;
        }

        public void OnGet()
        {
            contactMessages = ContactService.GetAllMessages(); 
        }
    }
}
