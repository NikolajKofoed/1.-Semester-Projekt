using SejlBåd.Models;

namespace SejlBåd.Services.AccountServices
{
    public interface IAccountService
    {
        void CreateAccount(Account account);
        Account GetAccount(int id);



        // methods for creating account
        void AddDummyAccount(Account account);
        Account GetDummyAccount(int id);
        Account CreateDummyAccount(Account account);
        void SetDateAndCountry(int id, DateOnly date, string country);
        void SetEmailAndPhoneNum(int id, string email, string phoneNum);
        void SetName(int id, string firstName, string lastName);
        void SetPassword(int id, string password);
        void SetUserName(int id, string userName);
    }
}
