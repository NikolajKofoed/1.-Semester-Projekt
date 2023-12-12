using SejlBåd.Models;
using SejlBåd.Pages.BoatPages;

namespace SejlBåd.Services.BoatService
{
    public interface IBoatService
    {

        void AddBoats(Boat boat);
        void DeleteBoats(Boat boat);
        Boat? LookUpBoat(int Id);
        Boat GetBoat(int id);
        List<Boat> listOfBoats();
        JuniorBoat GetJuniorModel(int id);
        IBoatService DeleteBoats(int id);
        JuniorBoat DeleteJuniorModel();
        void EditJuniorModel(Boat boat);
        void DeleteJunior(JuniorBoat boat);
    }
}
