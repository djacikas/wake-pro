using System.ComponentModel.DataAnnotations;

namespace WakeProWebApi.Models
{
   public class TrickSubstepMapping
   {
      [Key]
      public int MappingId { get; set; }
      public int TrickId { get; set; }
      public int SubstepId { get; set; }
      public int Order { get; set; }

   }
}
