using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.SailingClassServices
{
    public class JsonFileSCJuniorService
    {
        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "SailingClass.json");
            }
        }

        IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileSCJuniorService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public void SaveJsonSC(List<User> SCUsers)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<User[]>(jsonFileWriter, SCUsers.ToArray());
            }
        }

        public IEnumerable<User> GetJsonSCUsers()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<User[]>(jsonFileReader.ReadToEnd());
            }
        }
    }
}

