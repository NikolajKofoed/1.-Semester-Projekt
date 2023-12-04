using SejlBåd.MockData.EventMock;
using SejlBåd.Models;

namespace SejlBåd.Services.EventServices
{
    public class EventService : IEventService
    {
        private List<Models.Event> _events = EventMockData.GetEvents();
        private JsonFileEventService _jsonEventService;

        public EventService (JsonFileEventService jsonEventService)
        {
            _jsonEventService = jsonEventService;
            _events = _jsonEventService.GetJsonEvents().ToList();
        }

        public List<Models.Event> GetEvents()
        {
            return _events;
        }

        public void CreateEvent(Models.Event evt)
        {
            _events.Add(evt);
            _jsonEventService.SaveJsonEventData(_events);
        }

        public void DeleteEvent(int eventid)
        {
            foreach (var evt in _events)
            {
                if (evt.EventId == eventid)
                {
                    _events.Remove(evt);
                    _jsonEventService.SaveJsonEventData(_events);
                    break;
                }
            }
        }

        Event IEventService.GetEvent(int eventId)
        {
            foreach(var evt in _events)
            {
                if(evt.EventId == eventId)
                {
                    return evt;
                }
            }
            return null;
        }
    }
}
