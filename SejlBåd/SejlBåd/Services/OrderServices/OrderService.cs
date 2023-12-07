using Microsoft.AspNetCore.WebUtilities;
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

        public Order GetOrder(int id)
        {
            foreach(var order in orders)
            {
                if(order.Id == id)
                {
                    return order;
                }
            }
            return null;
        }
        public Order NewOrder(DockSpot? dockSpot, User? user, SailingClass? Sc)
        {
            Order order = new Order(dockSpot, user, Sc, null, null);
            orders.Add(order);
            _jsonOrderService.SaveJsonOrders(orders);
            return order;
        }
        public Order CreateOrderDockSpot(DockSpot dockSpot, User user)
        {

            Order order = new Order(dockSpot, user, null, DateTime.Now, 400);
            orders.Add(order);
            _jsonOrderService.SaveJsonOrders(orders);
            return order;
            
        }

        public DockSpot[] GetDockSpots()
        {
            return dockSpots;
        }
    }
}
