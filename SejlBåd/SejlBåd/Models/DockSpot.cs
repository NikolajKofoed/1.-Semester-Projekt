using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SejlBåd.Models
{
    public class DockSpot
    {
        private int nextId = 1;
        public int Id { get; set; }
        public User? Renter { get; set; }
        public bool IsAvailable { get; set; }

        public DateTime? RentPeriodStart { get; set; }

        public double YearlyContigent { get; set; }
        public DockSpot(User? renter, DateTime? rentPeriodStart)
        {
            Id = nextId++;
            Renter = renter;
            RentPeriodStart = rentPeriodStart;
            YearlyContigent = 400;
        }

        public DockSpot()
        {
            Id = nextId++;
        }
    }
}
