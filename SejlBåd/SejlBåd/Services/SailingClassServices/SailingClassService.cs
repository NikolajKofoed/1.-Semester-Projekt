using SejlBåd.Models;
using SejlBåd.MockData.SailingClassMock;

namespace SejlBåd.Services.SailingClassServices
{
    public class SailingClassService : ISailingClassService
    {
        public List<Models.SailingClass> sailingClasses { get; set; }

        public SailingClassService()
        {
            sailingClasses = MockSailingClass.GetMockClasses();
        }

        public List<Models.SailingClass> GetSailingClasses()
        {
            throw new NotImplementedException();
        }

        public void RemoveSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        public void UpdateSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        public void GetSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        public void AddSailingClass(SailingClass sailingClass)
        {
            sailingClasses.Add(sailingClass);
        }

    }
}
