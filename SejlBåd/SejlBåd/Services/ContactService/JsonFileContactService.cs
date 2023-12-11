using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.ContactService;

public class JsonFileContactService
{
    IWebHostEnvironment WebHostEnvironment { get; }
    public JsonFileContactService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }
    private string JsonFileName
    {
        get
        {
            return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Contacts.json");
        }
    }
    public void SaveJsonContactData(List<Contact> messages)
    {
        using (FileStream jsonFileWriter = File.Create(JsonFileName))
        {
            Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
            {
                SkipValidation = false,
                Indented = true,
            });
            JsonSerializer.Serialize<Contact[]>(jsonFileWriter, messages.ToArray());
        }
    }
    public IEnumerable<Contact> GetContactData()
    {
        using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
        {
            try
            {
                return JsonSerializer.Deserialize<Contact[]>(jsonFileReader.ReadToEnd());
            }
            catch (JsonException)
            {
                return new List<Contact>();
            }

        }
    }
}
