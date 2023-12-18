﻿using Microsoft.AspNetCore.Mvc;

namespace SejlBåd.Models
{
    public class Boat
    {
        public static int nextID = 1;
        [BindProperty]
        public double Length { get; set; }
        public double Width { get; set; }
        public double Bom { get; set; }
        public bool? HasBom { get; set; }
        public double TopUnderMast { get; set; }
        public double Vægt { get; set; }    
        public bool? Booked { get; set; }
        public int Id { get; set; }

        public Boat(string boatName, double length, double width, double bom, bool hasBom, double topUnderMast, double vægt, bool booked)
        {
            Id = nextID++;
            Length = length;
            Width = width;
            Bom = bom;
            HasBom = hasBom;
            TopUnderMast = topUnderMast;
            Vægt = Vægt;
            Booked = booked;
        }
        public Boat()
        {
            Id = nextID++;
        }


    }
}
