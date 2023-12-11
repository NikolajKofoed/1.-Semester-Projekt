namespace SejlBåd.Models
{
    public class Contact
    {
        private static int nextId = 1;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public List<Contact>? MessageList { get; set; }

        public Contact(string firstName, string lastName, string email, string phone, string message)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Message = message;
        }

        public Contact()
        {
        }
    }
}
