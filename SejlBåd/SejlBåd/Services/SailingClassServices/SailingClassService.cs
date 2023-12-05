using SejlBåd.Models;
using SejlBåd.MockData.SailingClassMock;

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
        public void AddUserToClass(User user)
        {
            sailingClassUsers.Add(user);
            JsonFileSCService.SaveJsonSC(sailingClassUsers);
        }

        //public User GetUser(string email)
        //{
        //    foreach (var us in sailingClassUsers)
        //    {
        //        if(us.Email == email)
        //        {
        //            return us;
        //        }
        //    }
        //    return null;
        //}

    }
}
