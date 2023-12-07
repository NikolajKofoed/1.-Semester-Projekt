using SejlBåd.Models;
using SejlBåd.Services.DockSpotServices;

namespace SejlBåd.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        private JsonFileOrderService _jsonOrderService;
        private JsonFileDockSpotService _jsonDockSpotService;
        private IDockSpotService _dockSpotService;
        private List<Order> orders;
        private DockSpot[] dockSpots;

        public OrderService(JsonFileOrderService jsonFileOrderService, JsonFileDockSpotService jsonDockSpotService, IDockSpotService dockSpotService)
        {
            _jsonOrderService = jsonFileOrderService;
            _jsonDockSpotService = jsonDockSpotService;
            _dockSpotService = dockSpotService;
            orders = _jsonOrderService.GetJsonOrders().ToList();
            dockSpots = _dockSpotService.GetDockSpots();
        }

        public void CreateOrder(Order order)
        {

            if(order != null)
            {
                //foreach (var ds in dockSpots)
                //{
                //    if (ds.IsAvailable)
                //    {
                //        ds.Renter = order.Customer;
                //        ds.IsAvailable = false;
                //        ds.RentPeriodStart = DateTime.Now;
                //        _jsonDockSpotService.SaveJsonDockSpots(dockSpots);
                //        break;
                //    }
                //}
                foreach (var ds in dockSpots)
                {
                    if(order.Customer.Email == ds.Renter.Email)
                    {
                        order.DockSpot = ds;
                        order.TotalPrice = ds.YearlyContigent;
                        break;
                    }
                }
                order.OrderDate = DateTime.Now;
                orders.Add(order);

                _jsonOrderService.SaveJsonOrders(orders);
            }
        }

        public DockSpot[] GetDockSpots()
        {
            return dockSpots;
        }
    }
}
