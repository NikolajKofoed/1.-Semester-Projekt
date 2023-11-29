namespace SejlBåd.Models
{
    public class Member
    {

        public string? UserId { get; }
        public int? UserIdNum { get; set; }
        public string? UserIdString { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
