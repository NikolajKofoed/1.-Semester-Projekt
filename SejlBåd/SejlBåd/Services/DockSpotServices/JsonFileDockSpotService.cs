using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.DockSpotServices
{
    public class JsonFileDockSpotService
    {
        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnviroment.WebRootPath, "Data", "DockSpots.json");
            }
        }

        IWebHostEnvironment WebHostEnviroment { get; }

        public JsonFileDockSpotService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnviroment = webHostEnvironment;
        }

        public void SaveJsonDockSpots(DockSpot[] dockSpots)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<DockSpot[]>(jsonFileWriter, dockSpots.ToArray());
            }
        }

        public IEnumerable<DockSpot> GetJsonDockSpots()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<DockSpot[]>(jsonFileReader.ReadToEnd());
            }
        }
    }
}
