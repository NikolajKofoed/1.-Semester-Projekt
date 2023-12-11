using SejlBåd.Models;

namespace SejlBåd.Services.ContactService
{
    public class ContactService : IContactService
    {
        private List<Contact> _messages = MockData.ContactMock.ContactMock.GetAllMessages();
        private JsonFileContactService _jsonContactService;

        private int NextMessageId()
        {
            var maxId = 0;
            foreach(var message in _messages)
            {
                if (maxId < message.Id)
                    maxId = message.Id; 
            }
            return maxId + 1;
        }

        public ContactService(JsonFileContactService jsonContactService)
        {
            _jsonContactService = jsonContactService;
            _messages = _jsonContactService.GetContactData().ToList();
        }

        public List<Contact> GetAllMessages()
        {
            var reverseMessages = new List<Contact>();
            for (var i = _messages.Count - 1; i>= 0; i--)
            {
                reverseMessages.Add(_messages[i]);
            }
            return reverseMessages;
        }
        public void AddMessage(Contact contact)
        {
            contact.Id = NextMessageId();
            _messages.Add(contact);
            _jsonContactService.SaveJsonContactData(_messages);
        }

        public void UpdateMessage(Contact contact)
        {
            if (contact != null)
            {
                foreach (Contact i in _messages)
                {
                    if (i.Id == contact.Id)
                    {
                        i.FirstName = contact.FirstName;
                        i.LastName = contact.LastName;
                        i.Email = contact.Email;
                        i.Phone = contact.Phone;
                        i.Message = contact.Message;
                    }
                }
                _jsonContactService.SaveJsonContactData(_messages);
            }
        }

        public Contact DeleteMessage(int? messageId)
        {
            foreach (var i in _messages)
            {
                if (i.Id == messageId)
                {
                    _messages.Remove(i);
                    _jsonContactService.SaveJsonContactData(_messages);
                    break;
                }
            }
            return null;
        }

        public Contact ViewMessage(int messageId)
        {
            foreach (var message in _messages)
            {
                if (message.Id == messageId)
                {
                    return message;
                }
            }
            return null;
        }
    }
}
