using System.ComponentModel.DataAnnotations;

namespace WakeProWebApi.Models
{
   public class TrickSubStep
   {
      [Key]
      public int TrickSubStepId { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
   }
}
