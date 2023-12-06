using SejlBåd.Models;
using SejlBåd.Services.DockSpotServices;

namespace SejlBåd.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        private JsonFileOrderService _jsonOrderService;
        private JsonFileDockSpotService _jsonDockSpotService;
        private List<Order> orders;
        private DockSpot[] dockSpots;

        public OrderService(JsonFileOrderService jsonFileOrderService, JsonFileDockSpotService jsonDockSpotService)
        {
            _jsonOrderService = jsonFileOrderService;
            _jsonDockSpotService = jsonDockSpotService;
            orders = _jsonOrderService.GetJsonOrders().ToList();
            dockSpots = _jsonDockSpotService.GetJsonDockSpots().ToArray();
        }


    }
}
