using Microsoft.AspNetCore.Routing.Constraints;
using SejlBåd.Models;
using SejlBåd.Pages.BoatPages;

namespace SejlBåd.Services.BoatService
{
    public class BoatService : IBoatService
    {
        private JsonFileBoatService JsonFileBoatService { get; set; }

        List<Boat> boats;

        public BoatService(JsonFileBoatService jsonFileBoatService)
        {
            JsonFileBoatService = jsonFileBoatService;
            boats = JsonFileBoatService.GetJsonBoats().ToList();
        }

        public void AddBoats(Boat boat)
        {
            boats.Add(boat);
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

        public void DeleteBoats(int id)

        {
            foreach (Boat b in boats)
            {
                if (id == b.BoatId)
                {
                    boats.Remove(b);
                    break;
                }
            }
        }

        public void EditBoat(Boat boat)
        {
            foreach (Boat b in boats)
            {
                if (b.BoatId == boat.BoatId)
                {
                    b.Booked = boat.Booked;
                }
            }
        }
        public void CreateBoatModel(Boat boat)
        {
            throw new NotImplementedException();
        }
    }
}
