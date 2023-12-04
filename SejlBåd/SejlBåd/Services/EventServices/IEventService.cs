namespace SejlBåd.Services.EventServices
{
    public interface IEventService
    {
         List<Models.Event> GetEvents();
        void CreateEvent(Models.Event evt);
        void DeleteEvent(int eventId);
        void EditEvent(int eventId, string eventName, string eventDescription, DateTime eventDate);
        Models.Event GetEvent(int eventId);
    }
}
