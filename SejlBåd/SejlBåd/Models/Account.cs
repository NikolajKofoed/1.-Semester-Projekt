using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace SejlBåd.Models
{
    public class Account
    {
        private static int nextId = 1;
        public int Id { get; set; }

        public string? Password { get; set; }
        public string? UserName { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Dato skal være i det rigtige format")]
        public DateTime? DateOfBirth { get; set; }
        [MinLength(2)]
        public string? FirstName { get; set; }
        [MinLength(2)]
        public string? LastName { get; set; }

        [EmailAddress(ErrorMessage = "Email skal være i det rigtige format")]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "Telefon nummer skal være i det rigtige format")]
        public string? PhoneNumber { get; set; }

        public string? Role { get; set; }

        public Account()
        {
            Id = nextId++;
        }

        public Account(string password, string userName, DateTime dateOfBirth, string firstName, string lastName, string email, string? phoneNumber)
        {
            Id = nextId++;
            Password = password;
            UserName = userName;
            DateOfBirth = dateOfBirth;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Password)}={Password}, {nameof(UserName)}={UserName}, {nameof(DateOfBirth)}={DateOfBirth.ToString()}, {nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}, {nameof(Email)}={Email}, {nameof(PhoneNumber)}={PhoneNumber}, {nameof(Role)}={Role}}}";
        }
    }
}
