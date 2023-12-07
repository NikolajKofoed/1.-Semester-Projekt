namespace SejlBåd.Models
{
    public class Boat
    {
        public static int nextID = 1;
        public double Length { get; set; }
        public int Id { get; set; }
        public double Width { get; set; }
        public double Bom { get; set; }
        public bool HasBom { get; set; }
        public double TopUnderMast { get; set; }
        public double Vægt { get; set; }    
        public bool Booked { get; set; }

        public Boat(double length, double width, double bom, bool hasBom, double topUnderMast, double vægt, bool booked)
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

        }
        public override string ToString()
        {
            return $"{{{nameof(Length)}={Length.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(Width)}={Width.ToString()}, {nameof(Bom)}={Bom.ToString()}, {nameof(HasBom)}={HasBom.ToString()}, {nameof(TopUnderMast)}={TopUnderMast.ToString()}, {nameof(Vægt)}={Vægt.ToString()}, {nameof(Booked)}={Booked.ToString()}}}";
        }
    }
}
