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
                return Path.Combine(WebHostEnviroment.WebRootPath, "Data", "Boats.json");
            }
        }

        IWebHostEnvironment WebHostEnviroment { get; }

        public JsonFileBoatListService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnviroment = webHostEnvironment;
        }

        public void SaveJsonBoats(List<Boats> boats)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Boats[]>(jsonFileWriter, boats.ToArray());
            }
        }

        public IEnumerable<Boats> GetJsonBoats()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Boats[]>(jsonFileReader.ReadToEnd());
            }
        }
    }
}
