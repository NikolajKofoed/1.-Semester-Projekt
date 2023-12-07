using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.CustomerServices
{
    public class JsonFileCustomerService
    {

        public string JsonFileName { get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Customers.Json"); } }

        IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileCustomerService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public void SaveJsonCustomers(List<User> Users)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<User[]>(jsonFileWriter, Users.ToArray());
            }
        }

        public IEnumerable<User> GetJsonCustomers()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<User[]>(jsonFileReader.ReadToEnd());
            }
        }

    }
}
