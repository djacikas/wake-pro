using System.ComponentModel.DataAnnotations;

namespace WakeProWebApi.Models
{
   public class UserTrickProgress
   {
      [Key]
      public int UserTrickProgressId { get; set; }
      public int UserId { get; set; }
      public int TrickId { get; set; }
      public int TrickSubStepId { get; set; }
      public bool IsCompleted { get; set; }
   }
}
