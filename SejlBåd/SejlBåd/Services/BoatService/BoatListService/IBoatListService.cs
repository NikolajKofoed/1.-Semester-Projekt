using SejlBåd.Models;

namespace SejlBåd.Services.BoatService.BoatListService
{
    public interface IBoatListService
    {

        List<Boat> GetJuniorBoats();
        List<Boat> GetVoksenBoats();
        List<Boat> GetSeniorBoats();

        List<Boat> GetBoatList(int id);


    }
}
