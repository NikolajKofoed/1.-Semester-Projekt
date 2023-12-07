using SejlBåd.Models;

namespace SejlBåd.Services.OrderServices
{
    public interface IOrderService
    {

        Order CreateOrderDockSpot(DockSpot dockSpot, User user);

        DockSpot[] GetDockSpots();

        Order GetOrder(int id);

        Order NewOrder(DockSpot? dockSpot, User? user, SailingClass? Sc);
    }
}
