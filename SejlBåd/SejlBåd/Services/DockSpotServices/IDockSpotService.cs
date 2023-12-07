using SejlBåd.Models;

namespace SejlBåd.Services.DockSpotServices
{
    public interface IDockSpotService
    {

        DockSpot RentSpot(User user, DockSpot dockSpot);
        void UpdateSpot();
        DockSpot[] GetDockSpots();
        DockSpot GetDockSpot(int id);
        void CancelReservation(DockSpot dockSpot);
        DockSpot GetNextAvailableDockSpot();
        DockSpot CheckDogSpots();

    }
}
