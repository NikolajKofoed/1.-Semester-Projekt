using SejlBåd.Models;

namespace SejlBåd.Services.ContactService
{
    public interface IContactService
    {
        List<Contact> GetAllMessages();
        void AddMessage(Contact contact);
        Contact DeleteMessage(int? messageId);
        void UpdateMessage(Contact contact);
        public Contact ViewMessage(int messageId); 
    }
}
