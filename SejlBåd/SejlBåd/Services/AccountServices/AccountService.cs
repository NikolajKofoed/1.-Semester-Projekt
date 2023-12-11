using SejlBåd.Models;

namespace SejlBåd.Services.AccountServices
{
    public class AccountService : IAccountService
    {
        private List<Account> _accounts;
        private List<Account> _dummyAccounts = new List<Account>();
        private JsonFileAccountService _jsonFileAccountService;

        public AccountService(JsonFileAccountService jsonFileAccountService)
        {
            _jsonFileAccountService = jsonFileAccountService;
            _accounts = _jsonFileAccountService.GetJsonAccounts().ToList();
        }



        public void CreateAccount(Account account)
        {
            _accounts.Add(account);
            _jsonFileAccountService.SaveJsonAccounts(_accounts);

        }


        public Account GetAccount(int id)
        {
            return _dummyAccounts.FirstOrDefault(account => account.Id == id);
        }

        // dummy account methods
        void IAccountService.AddDummyAccount(Account account)
        {
            if (account != null)
            {
                _dummyAccounts.Add(account);
            }
        }

        public Account CreateDummyAccount(Account account)
        {
            account.Role = "User";
            _dummyAccounts.Add(account);
            return account;
        }
        public Account GetDummyAccount(int id)
        {
            return _dummyAccounts.FirstOrDefault(account => account.Id == id);
        }

        // Making account

        void IAccountService.SetDateAndCountry(int id, DateOnly date, string country)
        {
            foreach(var ac in _dummyAccounts)
            {
                if(ac.Id == id)
                {
                    ac.DateOfBirth = date;
                    ac.Country = country;

                }
            }
        }

        void IAccountService.SetEmailAndPhoneNum(int id, string email, string phoneNum)
        {
            foreach (var ac in _dummyAccounts)
            {
                if (ac.Id == id)
                {
                    ac.Email = email;
                    ac.PhoneNumber = phoneNum;

                }
            }
        }

        void IAccountService.SetName(int id, string firstName, string lastName)
        {
            foreach (var ac in _dummyAccounts)
            {
                if (ac.Id == id)
                {
                    ac.FirstName = firstName;
                    ac.LastName = lastName;

                }
            }
        }

        void IAccountService.SetPassword(int id, string password)
        {
            foreach (var ac in _dummyAccounts)
            {
                if (ac.Id == id)
                {
                    ac.Password = password;

                }
            }
        }

        void IAccountService.SetUserName(int id, string userName)
        {
            foreach(var ac in _dummyAccounts)
            {
                if(ac.Id == id)
                {
                    ac.UserName = userName;

                }
            }        
        }
    }
}
