
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

        DockSpot IDockSpotService.GetNextAvailableDockSpot()
        {
            foreach(var ds in dockSpots)
            {
                if (ds.IsAvailable)
                {
                    return ds;
                }
            }
            return null;
        }

        DockSpot IDockSpotService.RentSpot(User user, DockSpot dockSpot)
        {
            if(user != null)
            {
                foreach(var ds in dockSpots)
                {
                    if(ds.Id == dockSpot.Id && ds.IsAvailable)
                    {
                        ds.Renter = user;
                        ds.IsAvailable = false;
                        ds.RentPeriodStart = DateTime.Now;
                        _jsonDockSpotService.SaveJsonDockSpots(dockSpots);
                        return ds;
                    }
                }
            }
            return null;
            
        }

        void IDockSpotService.UpdateSpot()
        {
            throw new NotImplementedException();
        }

        DockSpot IDockSpotService.CheckDogSpots()
        {
            foreach(var ds in dockSpots)
            {
                if(ds != null)
                {
                    return ds;
                }
            }
            return null;
        }
    }
}
