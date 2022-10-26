using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApplication1.model
{
    public class book
    {
        [JsonPropertyName("id")]
        public int book_id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<book>(this);
        }
    }
}
