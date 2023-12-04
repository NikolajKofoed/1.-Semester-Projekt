
using SejlBåd.Models;

namespace SejlBåd.Services.DockSpotServices
{
    public class DockSpotService : IDockSpotService
    {
        private DockSpot[] dockSpots;
        private JsonFileDockSpotService _jsonDockSpotService;

        public DockSpotService(JsonFileDockSpotService jsonDockSpotService)
        {
            _jsonDockSpotService = jsonDockSpotService;
            dockSpots = _jsonDockSpotService.GetJsonDockSpots().ToArray();
        }

        void IDockSpotService.CancelReservation(DockSpot dockSpot)
        {
            if(dockSpot != null)
            {
                foreach(var ds in dockSpots)
                {
                    if(dockSpot.Id == ds.Id)
                    {
                        ds.Renter = null;
                        ds.IsAvailable = true;
                        ds.RentPeriodStart = null;
                        ds.RentPeriodEnd = null;
                    }
                }
            }
            _jsonDockSpotService.SaveJsonDockSpots(dockSpots);
        }

        DockSpot IDockSpotService.GetDockSpot(int id)
        {
            foreach(var dockSpot in dockSpots)
            {
                if(dockSpot.Id == id)
                {
                    return dockSpot;
                }
            }
            return null;
        }

        DockSpot[] IDockSpotService.GetDockSpots()
        {
            return dockSpots;
        }

        void IDockSpotService.RentSpot(DockSpot dockSpot, User user, DateTime start, DateTime end)
        {
            if(dockSpot != null || user != null)
            {
                foreach(var ds in dockSpots)
                {
                    if(dockSpot.Id == ds.Id)
                    {
                        ds.Renter = user;
                        ds.IsAvailable = false;
                        ds.RentPeriodStart = start;
                        ds.RentPeriodEnd = end;
                    }
                }
            }
            _jsonDockSpotService.SaveJsonDockSpots(dockSpots);
        }

        void IDockSpotService.UpdateSpot()
        {
            throw new NotImplementedException();
        }

    }
}
