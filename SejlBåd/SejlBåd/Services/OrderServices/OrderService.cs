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

        public void CreateOrderDockSpot(DockSpot dockSpot, User user)
        {

            orders.Add(new Order(dockSpot, user, null, DateTime.Now, 400));
            _jsonOrderService.SaveJsonOrders(orders);
            
        }

        public DockSpot[] GetDockSpots()
        {
            return dockSpots;
        }
    }
}
