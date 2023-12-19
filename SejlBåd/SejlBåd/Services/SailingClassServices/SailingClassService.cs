using SejlBåd.Models;
using SejlBåd.MockData.SailingClassMock;
using SejlBåd.MockData.EventMock;
using System.Data;

namespace SejlBåd.Services.SailingClassServices
{
    public class SailingClassService : ISailingClassService
    {
        private JsonFileSailingClassService _jsonFileSailingClassService;
        public List<SailingClass> sailingClasses { get; set; }
        public List<User> users;


        private List<User> _sCJuniors;
        private List<User> _sCSeniors;

        public SailingClassService(JsonFileSailingClassService jsonFileSailingClassService)
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

        public List<SailingClass> GetSailingClasses()
        {
            return sailingClasses;
        }

        User ISailingClassService.AddUserToJuniorClass(User user)
        {
            sailingClasses[0].Participants.Add(user);
            _jsonFileSailingClassService.SaveJsonSailingClass(sailingClasses);
            return user;
        }

        User ISailingClassService.AddUserToSeniorClass(User user)
        {
            sailingClasses[1].Participants.Add(user);
            _jsonFileSailingClassService.SaveJsonSailingClass(sailingClasses);
            return user;
        }

        //er ikke implementeret, da user er sat op på Email, og det er svært at validere vores user den vej igennem
        public void CancelUserToClass(User user)
        {
            throw new NotImplementedException();
        }


        //public void AddSailingClass(SailingClass sailingClass)
        //{
        //    sailingClasses.Add(sailingClass);
        //    _jsonFileSailingClassService.SaveJsonSailingClass(sailingClasses);
        //}

        void ISailingClassService.AddSailingC(SailingClass sailingClass)
        {
            sailingClasses.Add(sailingClass);
            _jsonFileSailingClassService.SaveJsonSailingClass(sailingClasses);
        }

        void ISailingClassService.RemoveSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        void ISailingClassService.UpdateSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        //void ISailingClassService.GetSailingClass(SailingClass sailingClass)
        //{
        //    throw new NotImplementedException();
        //}

        //void ISailingClassService.AddUserToClass(User user)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
