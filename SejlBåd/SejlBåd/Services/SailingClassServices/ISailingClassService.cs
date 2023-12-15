using SejlBåd.Models;

namespace SejlBåd.Services.SailingClassServices
{
    public interface ISailingClassService
    {
        List<User> GetSailingClassJunior();
        List<User> GetSailingClassSenior();
        SailingClass AddSailingClass(SailingClass sailingClass);

        void AddSailingC(SailingClass sailingClass);

        User AddUserToJuniorClass(User user);
        User AddUserToSeniorClass(User user);

        void CancelUserToClass(User user);

        void RemoveSailingClass(SailingClass sailingClass);
        void UpdateSailingClass(SailingClass sailingClass);
        void GetSailingClass(SailingClass sailingClass);
        void AddUserToClass(User user);

        List<SailingClass> GetSailingClasses();
    }
}
