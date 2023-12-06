namespace SejlBåd.Models
{
    public class Order
    {
        static int nextId = 1;
        public int Id { get; set; }
        public DockSpot? DockSpot { get; set; }
        public User Customer { get; set; }
        public SailingClass? SailingClass { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }

        public Order()
        {
            Id = nextId++;
        }

        public Order(DockSpot? dockSpot, User customer, SailingClass? sailingClass, DateTime orderDate, double totalPrice)
        {
            Id = nextId++;
            DockSpot = dockSpot;
            Customer = customer;
            SailingClass = sailingClass;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(DockSpot)}={DockSpot}, {nameof(Customer)}={Customer}, {nameof(SailingClass)}={SailingClass}, {nameof(OrderDate)}={OrderDate.ToString()}, {nameof(TotalPrice)}={TotalPrice.ToString()}}}";
        }
    }
}
