using Newtonsoft.Json;
using WakeProApi.Enums;

namespace WakeProApi.Models
{
   public class Trick
   {

      [JsonProperty(PropertyName = "id")]
      public int Id { get; set; }

      [JsonProperty(PropertyName = "name")]
      public string Name { get; set; }

      [JsonProperty(PropertyName = "description")]
      public string Description { get; set; }

      //TODO: Update to use enum Level
      [JsonProperty(PropertyName = "level")]
      public string Level { get; set; }

      [JsonProperty(PropertyName = "image")]
      public string Image { get; set; }

      [JsonProperty(PropertyName = "video")]
      public string Video { get; set; }
   }
}
