using Microsoft.AspNetCore.Mvc.Rendering;

namespace SejlBåd.Services.EventServices
{
    public interface IEventService
    {
         List<Models.Event> GetEvents();
        void CreateEvent(Models.Event evt);
        Models.Event DeleteEvent(int? eventId);
        void EditEvent(Models.Event evt);
        Models.Event GetEvent(int eventId);
    }
}
