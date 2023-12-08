using SejlBåd.Models;

namespace SejlBåd.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        JsonFileCustomerService _jsonFileCustomerService;
        List<User> users;

        public CustomerService (JsonFileCustomerService jsonFileCustomerService)
        {
            _jsonFileCustomerService = jsonFileCustomerService;
            users = _jsonFileCustomerService.GetJsonCustomers().ToList();
        }

        User ICustomerService.CheckForExistingUser(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                foreach(var user in users)
                {
                    if(user.Email == email)
                    {
                        return user;
                    }
                }
            }
            return null;
        }

        User ICustomerService.CreateUser(User user)
        {
            if(user != null)
            {
                // check if a user with that email already exists
                foreach(var us in users)
                {
                    if(user.Email == us.Email)
                    {
                        return null;
                    }
                }

                users.Add(user);
                _jsonFileCustomerService.SaveJsonCustomers(users);
                return user;
            }
            return null;
        }
    }
}
