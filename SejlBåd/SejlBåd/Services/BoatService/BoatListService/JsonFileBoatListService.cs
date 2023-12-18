using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.BoatService.BoatListService
{
    public class JsonFileBoatListService
    {
        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnviroment.WebRootPath, "Data", "Boat.json");
            }
        }

        IWebHostEnvironment WebHostEnviroment { get; }

        public JsonFileBoatListService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnviroment = webHostEnvironment;
        }

        public void SaveJsonBoats(List<Boat> boats)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Boat[]>(jsonFileWriter, boats.ToArray());
            }
        }

        public IEnumerable<Boat> GetJsonBoats()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Boat[]>(jsonFileReader.ReadToEnd());
            }
        }
    }
}
