﻿using SejlBåd.Models;

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

        private int NextAccountId()
        {
            var maxId = 0;
            foreach (var acc in _accounts)
            {
                if (maxId < acc.Id)
                    maxId = acc.Id;
            }
            return maxId + 1;
        }
        // create account
        public void CreateAccount(Account account)
        {
            account.Id = NextAccountId();
            _accounts.Add(account);
            _jsonFileAccountService.SaveJsonAccounts(_accounts);

        }

        #region Account Methods
        //account methods

        public List<Account> GetAccounts()
        {
            return _accounts;
        }
        public Account GetAccount(int id)
        {
            return _dummyAccounts.FirstOrDefault(account => account.Id == id);
        }

        public Account GetAccount(string userName)
        {
            return _dummyAccounts.FirstOrDefault(account => account.UserName == userName);
        }

        public Account Login(string userName, string password)
        {
            if(!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                // check for matching account
                return _accounts.FirstOrDefault(value => value.UserName == userName && value.Password == password);
            }
            return null;
        }

        #endregion


        #region Dummy Account Methods
        // dummy account methods
        void IAccountService.AddDummyAccount(Account account)
        {
            if (account != null)
            {
                _dummyAccounts.Add(account);
            }
        }

        public List<Account> GetDummyAccounts()
        {
            return _dummyAccounts;
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

        void IAccountService.SetDateAndCountry(int id, DateTime date)
        {
            foreach(var ac in _dummyAccounts)
            {
                if(ac.Id == id)
                {
                    ac.DateOfBirth = date;

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

        bool IAccountService.SetUserName(int id, string userName)
        {
            foreach(var acc in _accounts)
            {
                if(acc.UserName == userName)
                {
                    return false;
                }
            }
            foreach(var ac in _dummyAccounts)
            {
                if(ac.Id == id)
                {
                    ac.UserName = userName;

                }
            }
            return true;
        }
        #endregion
    }
}
