using System.ComponentModel.DataAnnotations;

namespace SejlBåd.Models
{
    public class Member
    {
        public string? UserId { get; set; }

        [Required(ErrorMessage = "must be 4 numbers")]
        // should be 4 numbers long
        public int? UserIdNum { get; set; }

        [Required(ErrorMessage = "Must be between 1 and 16 letters"), MaxLength(16), MinLength(1)]
        public string? UserIdString { get; set; }

        [Required]
        // must contain a valid form of email(hotmail.com, gmail.com etc)
        // must contain 1 "@"
        // must contain atleast 1 letter or number before @
        // email should be able to be verified, but not required?
        public string? Email { get; set; }

        [Required(ErrorMessage = "Must be between 1 and 16 letters"), MaxLength(16), MinLength(1)]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Must be between 4 and 16 letters"), MaxLength(16), MinLength(4)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Must be between 4 and 16 letters"), MaxLength(16), MinLength(4)]
        // must not contain numbers or symbols
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Must be between 4 and 16 letters"), MaxLength(16), MinLength(4)]
        // must not contain numbers or symbols
        public string? LastName { get; set; }

        [Required]
        // must be 8 digits long
        // must contain numbers only
        public string? PhoneNumber { get; set; }

        public Member() { }

        public Member(string email, string userName, string password, string firstName, string lastName, string phoneNumber, int userIdNum, string userIdString)
        {
            UserIdNum = userIdNum;
            UserIdString = userIdString;
            Email = email;
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{{{nameof(Email)}={Email}, {nameof(UserName)}={UserName}, {nameof(Password)}={Password}, {nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}, {nameof(UserIdString)}={UserIdString}, {nameof(UserIdNum)}={UserIdNum.ToString()}}}";
        }
    }
}
