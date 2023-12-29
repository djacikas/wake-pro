using System.ComponentModel.DataAnnotations;

namespace WakeProWebApi.Models
{
   public class LearningPattern
   {
      [Key]
      public int LearningPatternId { get; set; }
      public string Name { get; set; }
   }
}
