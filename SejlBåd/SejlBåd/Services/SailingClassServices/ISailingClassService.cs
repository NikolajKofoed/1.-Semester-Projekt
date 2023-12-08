using SejlBåd.Models;

namespace SejlBåd.Services.SailingClassServices
{
    public interface ISailingClassService
    {
        List<User> GetSailingClassJunior();
        List<User> GetSailingClassSenior();
        SailingClass AddSailingClass(SailingClass sailingClass);

        SailingClass RemoveSailingClass(SailingClass sailingClass);
        void UpdateSailingClass(SailingClass sailingClass);
        SailingClass GetSailingClass(SailingClass sailingClass);
        void AddUserToJuniorClass(User user);
        void AddUserToSeniorClass(User user);

        List<SailingClass> GetSailingClasses();

    }
}
