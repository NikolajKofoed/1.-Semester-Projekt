using Microsoft.AspNetCore.Routing.Constraints;
using SejlBåd.Models;
using SejlBåd.Pages.BoatPages;
using SejlBåd.Services.BoatService.BoatListService;

namespace SejlBåd.Services.BoatService
{
    public class BoatService : IBoatService
    {
        private JsonFileBoatService JsonFileBoatService { get; set; }
        private JsonFileBoatListService _jsonFileBoatListService;

        List<Boat> boats;
        List<Boats> boatList;


        public BoatService(JsonFileBoatService jsonFileBoatService, JsonFileBoatListService jsonFileBoatListService)
        {
            JsonFileBoatService = jsonFileBoatService;
            _jsonFileBoatListService = jsonFileBoatListService;
            boats = JsonFileBoatService.GetJsonBoats().ToList();
            boatList = _jsonFileBoatListService.GetJsonBoats().ToList();
        }




        public void AddBoats(int id, Boat boat)
        {
            boats.Add(boat);
            boatList[id - 1].BoatList.Add(boat);
            _jsonFileBoatListService.SaveJsonBoats(boatList);
            JsonFileBoatService.SaveJsonBoats(boats);
        }

        public Boat GetBoat(int id)
        {

            foreach (var boat in boats)
            {
                if (boat.Id == id)
                {
                    return boat;
                }
            }
            return null;
        }
        public List<Boat> listOfBoats()
        {
            return boats;
        }

        public Boat DeleteBoat(int id, Boat boat)

        {
            foreach (Boat b in boatList[id - 1].BoatList)
            {
                if (boat.Id == b.Id)
                {
                    boats.Remove(b);
                    boatList[id - 1].BoatList.Remove(b);
                    _jsonFileBoatListService.SaveJsonBoats(boatList);
                    JsonFileBoatService.SaveJsonBoats(boats);
                    return b;
                }
            } 
            return null; 
        }

        public void EditBoat(Boat boat)
        {
            foreach (Boat b in boats)
            {
                if (b.Id == boat.Id)
                {
                    b.Booked = boat.Booked;
                }
            }
        }
        public void CreateBoatModel(Boat boat)
        {
            throw new NotImplementedException();
        }

        // Boats

        public Boats GetBoats(int id)
        {
            foreach (var b in boatList)
            {
                if (b.Id == id)
                {
                    return b;
                }
            }
            return null;
        }

        public List<Boat> GetBoatList(int id)
        {
            foreach (var b in boatList)
            {
                if (b.Id == id)
                {
                    return b.BoatList;
                }
            }
            return null;
        }
    }
}
