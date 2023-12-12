using Microsoft.AspNetCore.Routing.Constraints;
using SejlBåd.Models;
using SejlBåd.Pages.BoatPages;

namespace SejlBåd.Services.BoatService
{
    public class BoatService : IBoatService
    {
        private JsonFileBoatService JsonFileBoatService { get; set; }

        List<Boat> boats;

        public BoatService(JsonFileBoatService jsonFileBoatService)
        {
            JsonFileBoatService = jsonFileBoatService;
            boats = JsonFileBoatService.GetJsonBoats().ToList();
        }

        public void AddBoats(Boat boat)
        {
            boats.Add(boat);
        }

        public Boat GetBoat(int id)
        {

            foreach (var boat in boats)
            {
                if (boat.Id == id)
                {
                    return boat;
                }
            }
            return null;
        }
        public List<Boat> listOfBoats()
        {
            return boats;
        }

        public Boat? LookUpBoat(int Id)
        {
            foreach (var boat in boats)
            {
                if (boat.Id == Id)
                {
                    return boat;
                }
            }
            return null;
        }

        public void DeleteBoats(Boat boat)

        {
            foreach (Boat b in boats)
            {
                if (boat == b)
                {
                    boats.Remove(b);
                    break;
                }
            }
        }

        public void CreateBoatModel(Boat boat)
        {
            throw new NotImplementedException();
        }

        //JuniorModel IBoatService.GetJuniorModel(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //JuniorModel IBoatService.DeleteJuniorModel()
        //{
        //    throw new NotImplementedException();
        //}

        IBoatService IBoatService.DeleteBoats(int id)
        {
            throw new NotImplementedException();
        }


        void IBoatService.EditJuniorModel(Boat boat)
        {
            throw new NotImplementedException();
        }

        JuniorBoat IBoatService.GetJuniorModel(int id)
        {
            throw new NotImplementedException();
        }

        JuniorBoat IBoatService.DeleteJuniorModel()
        {
            throw new NotImplementedException();
        }

        void IBoatService.DeleteJunior(JuniorBoat boat)
        {
            throw new NotImplementedException();
        }
    }
}
