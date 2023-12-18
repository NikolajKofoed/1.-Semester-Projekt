using SejlBåd.Models;

namespace SejlBåd.Services.BoatService.BoatListService
{
    public class BoatListService : IBoatListService
    {


        List<Boats> boats;

        private JsonFileBoatListService _jsonFileBoatListService;

        public BoatListService(JsonFileBoatListService jsonFileBoatListService)
        {
            _jsonFileBoatListService = jsonFileBoatListService;
            boats = _jsonFileBoatListService.GetJsonBoats().ToList();

        }

        List<Boat> IBoatListService.GetJuniorBoats()
        {
            return boats[0].BoatList;
        }

        List<Boat> IBoatListService.GetSeniorBoats()
        {
            return boats[1].BoatList;
        }

        List<Boat> IBoatListService.GetVoksenBoats()
        {
            return boats[2].BoatList;
        }

        public List<Boat> GetBoatList(int id)
        {
            foreach(var b in boats)
            {
                if(b.Id == id)
                {
                    return b.BoatList;
                }
            }
            return null;
        }
    }
}
