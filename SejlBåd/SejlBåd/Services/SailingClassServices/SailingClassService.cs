using SejlBåd.Models;

namespace SejlBåd.Services.SailingClassServices
{
    public class SailingClassService : ISailingClassService
    {
        private JsonSailingClass _jsonFileSailingClassService;
      

        public List<Models.SailingClass> sailingClasses { get; set; }

        private List<User> _sCJunior;
        private List<User> _sCSenior;


        public SailingClassService(JsonSailingClass jsonFileSailingClassService)
        {
           _jsonFileSailingClassService = jsonFileSailingClassService;
            sailingClasses = _jsonFileSailingClassService.GetJsonSC().ToList();
        }

        List<User> ISailingClassService.GetSailingClassJunior()
        {
            return _sCJunior = sailingClasses[0].Participants;
        }

        List<User> ISailingClassService.GetSailingClassSenior()
        {
            return _sCSenior = sailingClasses[1].Participants;
        }
        void ISailingClassService.AddUserToJuniorClass(User user)
        {
            sailingClasses[0].Participants.Add(user);
            _jsonFileSailingClassService.SaveJsonSC(sailingClasses);
        }
        void ISailingClassService.AddUserToSeniorClass(User user)
        {
            sailingClasses[1].Participants.Add(user);
            _jsonFileSailingClassService.SaveJsonSC(sailingClasses);
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

      
    }
}
