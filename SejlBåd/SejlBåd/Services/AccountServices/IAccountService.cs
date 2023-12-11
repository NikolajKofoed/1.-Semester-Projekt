using SejlBåd.Models;

namespace SejlBåd.Services.AccountServices
{
    public interface IAccountService
    {
        // create account
        void CreateAccount(Account account);
        // acount methods
        Account GetAccount(int id);
        Account Login(string userName, string password);
        List<Account> GetAccounts();


        // methods for creating account, using dummy account
        void AddDummyAccount(Account account);
        Account GetDummyAccount(int id);
        Account CreateDummyAccount(Account account);
        void SetDateAndCountry(int id, DateOnly date, string country);
        void SetEmailAndPhoneNum(int id, string email, string phoneNum);
        void SetName(int id, string firstName, string lastName);
        void SetPassword(int id, string password);
        bool SetUserName(int id, string userName);
        List<Account> GetDummyAccounts();
    }
}
