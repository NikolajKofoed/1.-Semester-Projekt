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
        [Required(ErrorMessage = "Please Give A Renting Start Date")]
        public DateTime? RentPeriodStart { get; set; } = DateTime.Now;
        public DateTime? RentPeriodEnd { get; set; }
        public double MonthlyCost { get; set; }

        public DockSpot(User? renter, DateTime rentPeriodStart, DateTime rentPeriodEnd, double monthlyCost)
        {
            Id = nextId++;
            Renter = renter;
            RentPeriodStart = rentPeriodStart;
            RentPeriodEnd = rentPeriodEnd;
            MonthlyCost = monthlyCost;
        }

        public DockSpot()
        {
            Id = nextId++;
        }
    }
}
