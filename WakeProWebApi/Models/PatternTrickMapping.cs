using System.ComponentModel.DataAnnotations;

namespace WakeProWebApi.Models
{
   public class PatternTrickMapping
   {
      [Key]
      public int MappingId { get; set; }
      public int PatternId { get; set; }
      public int TrickId { get; set; }
   }
}
