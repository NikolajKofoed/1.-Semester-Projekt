using SejlBåd.Models;
using SejlBåd.MockData.SailingClassMock;
using SejlBåd.MockData.EventMock;

namespace SejlBåd.Services.SailingClassServices
{
    public class SailingClassService : ISailingClassService
    {
        private JsonFileSailingClass _jsonFileSailingClassService;

        public List<SailingClass> sailingClasses { get; set; }

        private List<User> _sCJuniors;
        private List<User> _sCSeniors;

        public SailingClassService(JsonFileSailingClass jsonFileSailingClassService)
        {
            _jsonFileSailingClassService = jsonFileSailingClassService;
            sailingClasses = _jsonFileSailingClassService.GetJsonSailingClass().ToList();


        }

        List<User> ISailingClassService.GetSailingClassJunior()
        {
            return _sCJuniors = sailingClasses[0].Participants;
        }

        List<User> ISailingClassService.GetSailingClassSenior()
        {
            return _sCSeniors = sailingClasses[1].Participants;
        }

        void ISailingClassService.AddUserToJuniorClass(User user)
        {
            sailingClasses[0].Participants.Add(user);
            _jsonFileSailingClassService.SaveJsonSailingClass(sailingClasses);
        }
        void ISailingClassService.AddUserToSeniorClass(User user)
        {
            sailingClasses[1].Participants.Add(user);
        }

        List<SailingClass> ISailingClassService.GetSailingClasses()
        {
            return sailingClasses;
        }




        SailingClass ISailingClassService.AddSailingClass(SailingClass sailingClass)
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
