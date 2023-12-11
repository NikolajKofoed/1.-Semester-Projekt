using SejlBåd.Models;
using SejlBåd.Pages.BoatPages;

namespace SejlBåd.Services.BoatService
{
    public interface IBoatService
    {

        void AddBoats(Boat boat);
        void DeleteeBoats(Boat boat);
        Boat? LookUpBoat(int Id);
        Boat GetBoat(int id);
        List<Boat> listOfBoats();
        JuniorModel GetJuniorModel(int id);
        IBoatService DeleteBoats(int id);
        JuniorModel DeleteJuniorModel();
    }
}
