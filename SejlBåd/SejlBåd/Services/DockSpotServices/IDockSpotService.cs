using SejlBåd.Models;

namespace SejlBåd.Services.DockSpotServices
{
    public interface IDockSpotService
    {

        DockSpot RentSpot(User user);
        void UpdateSpot();
        DockSpot[] GetDockSpots();
        DockSpot GetDockSpot(int id);
        void CancelReservation(DockSpot dockSpot);
        DockSpot GetNextAvailableDockSpot();
    }
}
