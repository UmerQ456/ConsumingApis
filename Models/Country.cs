using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ConsumingApis.Models
{
    public class Country
    {
        [JsonPropertyName("name")]

        [Required]
        public Name? Name { get; set; }

        [JsonPropertyName("capital")]

        [Required]
        public List<string>? Capital { get; set; }

        [JsonPropertyName("region")]

        [Required]
        public string? Region { get; set; }

        [JsonPropertyName("population")]
        public long Population { get; set; }
    }

    public class Name
    {
        [JsonPropertyName("common")]
        public string? Common { get; set; }
    }
}
