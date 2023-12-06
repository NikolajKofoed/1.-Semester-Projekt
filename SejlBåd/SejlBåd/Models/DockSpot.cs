﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SejlBåd.Models
{
    public class DockSpot
    {
        private int nextId = 1;
        public int Id { get; set; }
        public User? Renter { get; set; }
        public bool IsAvailable { get; set; }
        //[Required(ErrorMessage = "Please Give A Renting Start Date")]
        //[Range(typeof(DateTime), DateTime.Now.ToString(), "123", ErrorMessage = "123") ]
        // lowest date must be date of renting start
        public DateTime? RentPeriodStart { get; set; }
        //must higer date than start date
        // highest date should be 10years from start date
        public double MonthlyCost { get; set; }

        public DockSpot(User? renter, DateTime? rentPeriodStart, double monthlyCost)
        {
            Id = nextId++;
            Renter = renter;
            RentPeriodStart = rentPeriodStart;
            MonthlyCost = monthlyCost;
        }

        public DockSpot()
        {
            Id = nextId++;
        }
    }
}
