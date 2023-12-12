namespace SejlBåd.Models
{
    public class Account
    {
        private static int nextId = 1;
        public int Id { get; set; }

        public string? Password { get; set; }
        public string? UserName { get; set; }


        public string? Country { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public string? Role { get; set; }

        public Account()
        {
            Id = nextId++;
        }

        public Account(string password, string userName, string country, DateOnly dateOfBirth, string firstName, string lastName, string email, string? phoneNumber)
        {
            Id = nextId++;
            Password = password;
            UserName = userName;
            Country = country;
            DateOfBirth = dateOfBirth;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Password)}={Password}, {nameof(UserName)}={UserName}, {nameof(Country)}={Country}, {nameof(DateOfBirth)}={DateOfBirth.ToString()}, {nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}, {nameof(Email)}={Email}, {nameof(PhoneNumber)}={PhoneNumber}, {nameof(Role)}={Role}}}";
        }
    }
}
