namespace Sehvemderharbooket
{

    public class BoatRepository
    {
        private List<Boats> boats = new List<Boats>();

        public void AddBoats(Boats boat)
        {
            boats.Add(boat);
        }
        public void RemoveBoats(Boats boat)
        {
            boats.Remove(boat);
        }
        public Boats? LookUpBoat(int Id) //? - resultatet er null eller ej
        { 
            foreach (var boat in boats) //"var" her, er det samme som klassen Boats
            {
                if (boat.Id == Id) 
                    return boat;
            }
            return null; 
        }
        public BoatRepository? GetBoats() 
        {
            foreach (Boats boat in boats)
            {
                Console.WriteLine(boat);
            }
            return null;
        }

        //mangler UpdatedBoats
    }
}