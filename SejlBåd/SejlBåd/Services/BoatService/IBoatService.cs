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
        void EditBoat(int id, Boat boat);
        Boat GetBoat(int id );
        Boat RentBoat(int id, Boat boat, Account account);
        // Boats

        List<Boat> GetBoatList(int id);

        Boats GetBoats(int id);
    }
}
