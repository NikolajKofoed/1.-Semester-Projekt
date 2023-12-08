using SejlBåd.Models;

namespace SejlBåd.Services.CustomerServices
{
    public interface ICustomerService
    {

        User CreateUser(User user);

        User CheckForExistingUser(string email);


    }
}
