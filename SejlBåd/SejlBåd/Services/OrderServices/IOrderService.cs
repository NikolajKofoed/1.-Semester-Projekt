using SejlBåd.Models;

namespace SejlBåd.Services.OrderServices
{
    public interface IOrderService
    {

        void CreateOrderDockSpot(DockSpot dockSpot, User user);

        DockSpot[] GetDockSpots();

    }
}
