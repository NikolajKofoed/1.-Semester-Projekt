using SejlBåd.Models;
using SejlBåd.MockData.SailingClassMock;
using SejlBåd.MockData.EventMock;

namespace SejlBåd.Services.SailingClassServices
{
    public class SailingClassService : ISailingClassService
    {
        private JsonFileSCService JsonFileSCService { get; set; }
        public User UserToClass { get; set; }

        public List<Models.SailingClass> sailingClasses { get; set; }
        public List<Models.User> sailingClassUsers { get; set; }

        public SailingClassService(JsonFileSCService jsonFileSCService)
        {
            JsonFileSCService = jsonFileSCService;
            sailingClassUsers = JsonFileSCService.GetJsonSCUsers().ToList();
        }

        public List<Models.SailingClass> GetSailingClasses()
        {
            return sailingClasses;
        }

        public void RemoveSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        SailingClass ISailingClassService.RemoveSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        void ISailingClassService.UpdateSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        SailingClass ISailingClassService.GetSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

      
    }
}
