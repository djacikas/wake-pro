using System.ComponentModel.DataAnnotations;

namespace WakeProWebApi.Models
{
   public class Trick
   {
      [Key]
      public int TrickId { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public Level DifficultyLevel { get; set; }
      public string VideoUrl { get; set; }
   }

   public enum Level
   {
      None, Basic, Intermediate, Pro
   }
}
