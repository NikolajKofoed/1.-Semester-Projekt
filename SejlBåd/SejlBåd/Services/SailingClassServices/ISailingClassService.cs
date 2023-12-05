using SejlBåd.Models;

namespace SejlBåd.Services.SailingClassServices
{
    public interface ISailingClassService
    {
        List<Models.SailingClass> GetSailingClasses();

        void AddSailingClass(SailingClass sailingClass);

        void RemoveSailingClass(SailingClass sailingClass);
        void UpdateSailingClass(SailingClass sailingClass);
        void GetSailingClass(SailingClass sailingClass);
        void AddUserToClass(User user);

    }
}
