using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehvemderharbooket
{
    public class Boats
    {
        public static int nextID = 1;
        public double Length { get; set; }
        public int Id { get; set; }
        public double Width { get; set; }
        public double Bom { get; set; }
        public bool HasBom { get; set; }
        public double TopUnderMast { get; set; }
        public bool Booked { get; set; }

        public Boats(double length, double width, double bom, bool hasBom, double topUnderMast, bool booked)
        {
            Id = nextID++;
            Length = length;
            Width = width;
            Bom = bom;
            HasBom = hasBom;
            TopUnderMast = topUnderMast;
            Booked = booked;
        }

        public override string ToString()
        {
            return $"{{{nameof(Length)}={Length.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(Width)}={Width.ToString()}, {nameof(Bom)}={Bom.ToString()}, {nameof(HasBom)}={HasBom.ToString()}, {nameof(TopUnderMast)}={TopUnderMast.ToString()}, {nameof(Booked)}={Booked.ToString()}}}";
        }
    }
}
