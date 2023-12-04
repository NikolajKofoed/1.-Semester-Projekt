using SejlBåd.Models;
using SejlBåd.MockData.SailingClassMock;

namespace SejlBåd.Services.SailingClassServices
{
    public class SailingClassService : ISailingClassService
    {
        private JsonFileSCService JsonFileSCService { get; set; }
        public User UserToClass { get; set; }

        public List<Models.SailingClass> sailingClasses { get; set; }

        public SailingClassService(JsonFileSCService jsonFileSCService)
        {
            JsonFileSCService = jsonFileSCService;
            sailingClasses = MockSailingClass.GetMockClasses();
            //UserToClass = JsonFileSCService.GetJsonSCUsers().ToList();
        }

        public List<Models.SailingClass> GetSailingClasses()
        {
            return sailingClasses;
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
