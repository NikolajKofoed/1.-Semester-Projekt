using SejlBåd.Models;

namespace SejlBåd.Services.BoatService
{
    public interface IBoatService
    {

         void AddBoats(Boat boat);
         void RemoveBoats(Boat boat);
         Boat? LookUpBoat(int Id);
         Boat GetBoat(int id);
         List<Boat> listOfBoats();
        void CreateBoatModel(Boat boat);
        void DeleteJunior(object boatId);
        Boat DeleteJunior(object id);
        JuniorModel GetjuniorModel(int id);
        void DeleteJunior(object juniorId);
    }
}
