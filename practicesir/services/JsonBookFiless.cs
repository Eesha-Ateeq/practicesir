using Microsoft.AspNetCore.Hosting;
using practicesir.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WebApplication1.model;

namespace WebApplication1.services
{
    public class JsonBookFiless
    {
        public JsonBookFiless(IWebHostEnvironment webHostEnvironment)
        {

            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }
        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "books.json");
            }
        }

        public IEnumerable<book> getBooksData()
        {
            using (var json_file = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<book[]>(json_file.ReadToEnd());
            }

        }

        
    }  
}
