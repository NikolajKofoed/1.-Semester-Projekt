using System.ComponentModel.DataAnnotations;

namespace SejlBåd.Models
{
    public class User
    {

        [Required(ErrorMessage = "Fornavn skal have en værdi")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Efternavn skal have en værdi")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Email Skal være i det rigtige format")]
        [Required(ErrorMessage = "Emal skal have en værdi")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Range(typeof(int), "10000000", "99999999")]
        public int? Tlf { get; set; }
        public CreditCard? CreditCardInfo { get; set; }

        public User(string firstName, string lastName, string email, int? tlf, CreditCard? creditCardInfo)
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
