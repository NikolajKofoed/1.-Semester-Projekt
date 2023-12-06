using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.OrderServices
{
    public class JsonFileOrderService
    {
        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnviroment.WebRootPath, "Data", "Orders.json");
            }
        }

        IWebHostEnvironment WebHostEnviroment { get; }

        public JsonFileOrderService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnviroment = webHostEnvironment;
        }

        public void SaveJsonOrders(List<Order> orders)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Order[]>(jsonFileWriter, orders.ToArray());
            }
        }

        public IEnumerable<Order> GetJsonOrders()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Order[]>(jsonFileReader.ReadToEnd());
            }
        }
    }
}
