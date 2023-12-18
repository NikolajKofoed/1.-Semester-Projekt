using SejlBåd.Models;
using SejlBåd.Pages.BoatPages;

namespace SejlBåd.Services.BoatService
{
    public interface IBoatService
    {

        // Boat

        List<Boat> listOfBoats();
        void AddBoats(int id, Boat boat);
        Boat DeleteBoat(int id, Boat boat);
        void EditBoat(Boat boat);
        Boat GetBoat(int id);

        // Boats

        List<Boat> GetBoatList(int id);

        Boats GetBoats(int id);


    }
}
