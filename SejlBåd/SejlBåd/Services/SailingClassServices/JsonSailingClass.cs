using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.SailingClassServices
{
	public class JsonSailingClass
	{
		private string JsonFileName
		{
			get
			{
				return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "SCJuniorUsers.json");
			}
		}

		IWebHostEnvironment WebHostEnvironment { get; }

		public JsonSailingClass(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;
		}

		public void SaveJsonSC(List<SailingClass> sailingClass)
		{
			using (FileStream jsonFileWriter = File.Create(JsonFileName))
			{
				Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
				{
					SkipValidation = false,
					Indented = true
				});
				JsonSerializer.Serialize<SailingClass[]>(jsonFileWriter, sailingClass.ToArray());
			}
		}

		public IEnumerable<SailingClass> GetJsonSC()
		{
			using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
			{
				return JsonSerializer.Deserialize<SailingClass[]>(jsonFileReader.ReadToEnd());
			}
		}
	}
}
