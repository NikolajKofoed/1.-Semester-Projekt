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


        public Boats GetBoats(int id)
        {
            foreach (var b in boats)
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
