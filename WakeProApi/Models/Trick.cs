using Newtonsoft.Json;

namespace WakeProApi.Models
{
   public class Trick
   {
      [JsonProperty("id")]
      public int Id { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("description")]
      public string Description { get; set; }

      [JsonProperty("level")]
      public string Level { get; set; }

      [JsonProperty("image")]
      public string Image { get; set; }

      [JsonProperty("video")]
      public string Video { get; set; }
   }
}
