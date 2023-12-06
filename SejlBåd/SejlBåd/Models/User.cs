namespace SejlBåd.Models
{
    public class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Tlf { get; set; }
        public CreditCard CreditCardInfo { get; set; }

        public User(string firstName, string lastName, string email, string? tlf, CreditCard creditCardInfo)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Tlf = tlf;
            CreditCardInfo = creditCardInfo;
        }

        public User()
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}, {nameof(Email)}={Email}, {nameof(Tlf)}={Tlf}, {nameof(CreditCardInfo)}={CreditCardInfo}}}";
        }
    }
}
