using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.MemberServices
{
    public class JsonFileMemberService
    {

        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnviroment.WebRootPath, "Data", "Members.json");
            }
        }

        IWebHostEnvironment WebHostEnviroment { get; }

        public JsonFileMemberService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnviroment = webHostEnvironment;
        }

        public void SaveJsonMembers(List<Member> members)
        {
            using(FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Member[]>(jsonFileWriter, members.ToArray());
            }
        }

        public IEnumerable<Member> GetJsonMembers()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Member[]>(jsonFileReader.ReadToEnd());
            }
        }

    }
}
