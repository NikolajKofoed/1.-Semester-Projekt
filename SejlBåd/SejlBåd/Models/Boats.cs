namespace SejlBåd.Models
{
    public class Boats
    {
        private int nextId = 1; 
        public int Id { get; set; }
        public List<Boat> BoatList { get; set; }
        public string Navn { get; set; }

        public Boats(List<Boat> boatList, string navn)
        {
            Id = nextId++;
            BoatList = boatList;
            Navn = navn;
        }

        public Boats()
        {
        }
    }
}
