using SejlBåd.Models;

namespace SejlBåd.Services.DockSpotServices
{
    public interface IDockSpotService
    {

        void RentSpot(DockSpot dockSpot, User user);
        void UpdateSpot();
        DockSpot[] GetDockSpots();
        DockSpot GetDockSpot(int id);
        void CancelReservation(DockSpot dockSpot);

    }
}
