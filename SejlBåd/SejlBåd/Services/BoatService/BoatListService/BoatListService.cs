using SejlBåd.Models;

namespace SejlBåd.Services.BoatService.BoatListService
{
    public class BoatListService : IBoatListService
    {


        List<Boat> juniorBoats;
        List<Boat> seniorBoats;
        List<Boat> voksenBoats;

        List<Boats> boats;

        private JsonFileBoatListService _jsonFileBoatListService;

        public BoatListService(JsonFileBoatListService jsonFileBoatListService)
        {
            _jsonFileBoatListService = jsonFileBoatListService;
            boats = _jsonFileBoatListService.GetJsonBoats().ToList();
        }

        List<Boat> IBoatListService.GetJuniorBoats()
        {
            return juniorBoats = boats[0].BoatList;
        }

        List<Boat> IBoatListService.GetSeniorBoats()
        {
            return voksenBoats = boats[1].BoatList;
        }

        List<Boat> IBoatListService.GetVoksenBoats()
        {
            return seniorBoats = boats[2].BoatList;
        }
    }
}
