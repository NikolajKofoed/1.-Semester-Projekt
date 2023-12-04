namespace SejlBåd.Services.EventServices
{
    public interface IEventService
    {
         List<Models.Event> GetEvents();
        void CreateEvent(Models.Event evt);
        void DeleteEvent(int eventId);
        Models.Event GetEvent(int eventId);
    }
}
