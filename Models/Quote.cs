using System.Text.Json.Serialization;

namespace FamousQuotes;

public class Quote
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        public string Content { get; set; }
        public string Author { get; set; }

        public List<string> Tags { get; set; }

        [JsonPropertyName("authorSlug")]
        public string AuthorSlug { get; set; }

        public int Length { get; set; }

        [JsonPropertyName("dateAdded")]
        public DateTime DateAdded { get; set; }

        [JsonPropertyName("dateModified")]
        public DateTime DateModified { get; set; }
    }
