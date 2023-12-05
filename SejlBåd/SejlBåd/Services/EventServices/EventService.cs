using Microsoft.AspNetCore.Mvc.Rendering;
using SejlBåd.MockData.EventMock;
using SejlBåd.Models;
using System.Diagnostics.Tracing;

namespace SejlBåd.Services.EventServices
{
    public class EventService : IEventService
    {
        private List<Models.Event> _events = EventMockData.GetEvents();
        private JsonFileEventService _jsonEventService;

        public EventService(JsonFileEventService jsonEventService)
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

        public Event DeleteEvent(int? eventid)
        {
            foreach(Event evt in _events)
            {
                if (evt.EventId == eventid)
                {
                    _events.Remove(evt);
                    _jsonEventService.SaveJsonEventData(_events);
                    return evt;
                }
            }
            return null;
        }

        Event IEventService.GetEvent(int eventId)
        {
            foreach (var evt in _events)
            {
                if (evt.EventId == eventId)
                {
                    return evt;
                }
            }
            return null;
        }

        public void EditEvent(Models.Event evt)
        {
            if (evt != null)
            {
                foreach(Event i in _events)
                {
                    if (i.EventId == evt.EventId)
                    {
                        i.EventName = evt.EventName;
                        i.EventDescription = evt.EventDescription;
                        i.EventDate = evt.EventDate;
                    }
                }
                _jsonEventService.SaveJsonEventData(_events);
            }
        }
    }
}
