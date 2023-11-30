using SejlBåd.Models;

namespace SejlBåd.Services.SailingClassServices
{
    public interface ISailingClassService
    {
        List<Models.SailingClass> GetSailingClasses();

        void AddSailingClass(Models.SailingClass sailingClass);

        void RemoveSailingClass(Models.SailingClass sailingClass);
        void UpdateSailingClass(Models.SailingClass sailingClass);
        void GetSailingClass(Models.SailingClass sailingClass);

    }
}
