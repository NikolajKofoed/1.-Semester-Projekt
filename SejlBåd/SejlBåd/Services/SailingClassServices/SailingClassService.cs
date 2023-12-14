﻿using SejlBåd.Models;
using SejlBåd.MockData.SailingClassMock;
using SejlBåd.MockData.EventMock;

namespace SejlBåd.Services.SailingClassServices
{
    public class SailingClassService : ISailingClassService
    {
        private JsonFileSailingClassService _jsonFileSailingClassService;
        public List<SailingClass> sailingClasses { get; set; }


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

        User ISailingClassService.CancelUserToClass(User user)
        {
            throw new NotImplementedException();
        }


        SailingClass ISailingClassService.AddSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        void ISailingClassService.AddSailingC(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        void ISailingClassService.RemoveSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        void ISailingClassService.UpdateSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        void ISailingClassService.GetSailingClass(SailingClass sailingClass)
        {
            throw new NotImplementedException();
        }

        void ISailingClassService.AddUserToClass(User user)
        {
            throw new NotImplementedException();
        }

    }
}
