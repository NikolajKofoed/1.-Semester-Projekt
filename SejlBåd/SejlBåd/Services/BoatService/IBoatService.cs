using SejlBåd.Models;
using SejlBåd.Pages.BoatPages;

namespace SejlBåd.Services.BoatService
{
    public interface IBoatService
    {

        List<Boat> listOfBoats();
        void AddBoats(Boat boat);
        void DeleteBoats(int id);
        void EditBoat(Boat boat);
        Boat GetBoat(int id);
      
    
    }
}
