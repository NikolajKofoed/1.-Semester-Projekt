using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.SailingClassServices
{
	public class JsonFileSailingClass
	{
		private string JsonFileName
		{
			get
			{
				return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "SailingClass.json");
			}
		}

		IWebHostEnvironment WebHostEnvironment { get; }

		public JsonFileSailingClass(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;
		}

		public void SaveJsonSailingClass(List<SailingClass> sailingClass)
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

		public IEnumerable<SailingClass> GetJsonSailingClass()
		{
			using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
			{
				return JsonSerializer.Deserialize<SailingClass[]>(jsonFileReader.ReadToEnd());
			}
		}
	}
}
