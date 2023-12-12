using SejlBåd.Models;

namespace SejlBåd.MockData.ContactMock
{
    public class ContactMock
    {
        private static List<Contact> _messageList = new List<Contact>()
        {
            new Contact("FirstName", "LastName", "email@email.com","12345678", "A message"),
            new Contact("FirstName", "LastName", "email@email.com", "23456789", "A message"),
            new Contact("FirstName", "LastName", "email@email.com", "34567891", "A message")
        };
        public static List<Contact> GetAllMessages()
        {
            return _messageList;
        }
    }
}
