using SejlBåd.Models;

namespace SejlBåd.Services.DockSpotServices
{
    public interface IDockSpotService
    {

        void RentSpot(DockSpot dockSpot, User user, DateTime start, DateTime end);
        void UpdateSpot();
        DockSpot[] GetDockSpots();
        DockSpot GetDockSpot(int id);
        void CancelReservation(DockSpot dockSpot);

    }
}
