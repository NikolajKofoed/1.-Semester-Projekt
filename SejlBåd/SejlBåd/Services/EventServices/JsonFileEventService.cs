using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.EventServices
{
    public class JsonFileEventService
    {
        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Events.json");
            }
        }

        IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileEventService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public void SaveJsonEventData(List<Event> events)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true,
                });
            JsonSerializer.Serialize<Event[]>(jsonFileWriter, events.ToArray());
            }
        }

        public IEnumerable<Event> GetJsonEvents()
        {
            using(StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Event[]>(jsonFileReader.ReadToEnd());
            }
        }
    }
}
