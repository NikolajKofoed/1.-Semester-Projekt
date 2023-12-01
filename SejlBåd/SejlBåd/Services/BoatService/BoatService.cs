using Microsoft.AspNetCore.Routing.Constraints;
using SejlBåd.Models;

namespace SejlBåd.Services.BoatService
{
    public class BoatService : IBoatService
    {
        private JsonFileBoatService JsonFileBoatService { get; set; }

        List<Boat> boats;

        public BoatService(JsonFileBoatService jsonFileBoatService, List<Boat> boats)
        {
            JsonFileBoatService = jsonFileBoatService;
            this.boats = JsonFileBoatService.GetJsonBoats().ToList();
        }

        void IBoatService.AddBoats(Boat boat)
        {
            boats.Add(boat);
        }

        Boat IBoatService.GetBoats()
        {

            foreach (var boat in boats)
            {
                if ( boat.Length == 200)
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

        Boat? IBoatService.LookUpBoat(int Id)
        {
            foreach (var boat in boats)
            {
                if (boat.Id == Id)
                {
                    return boat;
                }
            }
            return null;
        }

        void IBoatService.RemoveBoats(Boat boat)

        {
           foreach (Boat b in boats)
            {
                if (boat == b)
                {
                    boats.Remove(b);
                    break;
                }
            }
        }
    }
}
