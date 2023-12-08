using System.ComponentModel.DataAnnotations;

namespace SejlBåd.Models
{
    public class User
    {

        [Required(ErrorMessage = "Filling out the name space is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Filling out the name space is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "must be 8 digits")]
        [Range(typeof(int), "10000000", "99999999", ErrorMessage = "Phone number Must be 8 Digits")]
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
