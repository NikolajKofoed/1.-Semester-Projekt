using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.AccountServices
{
    public class JsonFileAccountService
    {
        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Accounts.json");
            }
        }

        IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileAccountService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public void SaveJsonAccounts(List<Account> accounts)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Account[]>(jsonFileWriter, accounts.ToArray());
            }
        }

        public IEnumerable<Account>? GetJsonAccounts()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                try
                {
                    return JsonSerializer.Deserialize<Account[]>(jsonFileReader.ReadToEnd());

                }
                catch (JsonException)
                {
                    return new List<Account>();
                }
            }
        }
    }
}
