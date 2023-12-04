using SejlBåd.MockData.EventMock;

namespace SejlBåd.Services.EventServices
{
    public class EventService : IEventService
    {
        private List<Models.Event> _events = MockData.EventMock.EventMockData.GetEvents();

        public List<Models.Event> GetEvents()
        {
            return _events;
        }

        public void CreateEvent(Models.Event evt)
        {
            _events.Add(evt);
        }
    }
}
