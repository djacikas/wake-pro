using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WakePro.Models;

namespace WakePro.ViewModels
{
   [QueryProperty(nameof(Models.TrickLevel), "TrickLevel")]
   public partial class TricksPageViewModel : BaseViewModel
   {
      [ObservableProperty]
      private string _test = "Test";

      [ObservableProperty]
      private string _trickLevel;

      public TricksPageViewModel()
      {
      }

      [RelayCommand]
      private async Task Back()
      {
         await Shell.Current.GoToAsync("..", true);
      }

      partial void OnTrickLevelChanged(string value)
      {
         LoadData(value);
      }

      public async Task LoadData(string selectedTrickLevel)
      {
         var data = await FetchDataBasedOnTricksLevel(selectedTrickLevel);
      }

      private async Task<object> FetchDataBasedOnTricksLevel(string selectedTrickLevel)
      {
         // Simulate fetching data
         await Task.Delay(1000);

         var mockTrick = new Trick
         {
            Id = 1,
            Order = 1,
            Class = "Water",
            Name = "Ollie 360°",
            Description = "A basic wakeboarding trick where the rider performs a 360-degree spin while in the air.",
            Level = Models.TrickLevel.Advanced, // Assuming TrickLevel is an enum with values like Beginner, Intermediate, Advanced, etc.
            Options = new
            {
               Stance = new[] { "Regular", "Switch" },
               Rotation = new[] { "FS", "BS" }
            },
            ImageId = "image_ollie360",
            VideoId = "video_ollie360"
         };

         return mockTrick;
      }
   }
}
