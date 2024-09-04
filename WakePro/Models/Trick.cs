namespace WakePro.Models
{
   public class Trick
   {
      public int Id { get; set; }
      public int Order { get; set; }
      public string Class { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public TrickLevel Level { get; set; }
      public object Options { get; set; }
      public string ImageId { get; set; }
      public string VideoId { get; set; }
   }
}
