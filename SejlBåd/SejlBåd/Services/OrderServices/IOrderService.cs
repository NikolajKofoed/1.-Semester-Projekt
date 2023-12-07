using SejlBåd.Models;

namespace SejlBåd.Services.OrderServices
{
    public interface IOrderService
    {

        void CreateOrder(Order order);

        DockSpot[] GetDockSpots();

    }
}
