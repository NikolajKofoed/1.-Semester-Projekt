﻿using SejlBåd.Models;
using System.Text.Json;

namespace SejlBåd.Services.BlogServices
{
    public class JsonFileBlogService
    {
        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "BlogPosts.json");
            }
        }

        IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileBlogService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public void SaveJsonBlogData(List<Blog> blogs)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Blog[]>(jsonFileWriter, blogs.ToArray());
            }
        }

        public IEnumerable<Blog>? GetJsonBlogData()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Blog[]>(jsonFileReader.ReadToEnd());
            }
        }
    }
}
