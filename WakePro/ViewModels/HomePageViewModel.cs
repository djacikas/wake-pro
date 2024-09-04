using System.Windows.Input;
using WakePro.Models;
using WakePro.Views;

namespace WakePro.ViewModels
{
   public class HomePageViewModel : BaseViewModel
   {
      public ICommand NavigateToBasicTricksCommand { get; }
      public ICommand NavigateToIntermediateTricksCommand { get; }
      public ICommand NavigateToAdvancedTricksCommand { get; }

      public HomePageViewModel()
      {
         NavigateToBasicTricksCommand = new Command(async () => await NavigateToTricks(TrickLevel.Basic));
         NavigateToIntermediateTricksCommand = new Command(async () => await NavigateToTricks(TrickLevel.Intermediate));
         NavigateToAdvancedTricksCommand = new Command(async () => await NavigateToTricks(TrickLevel.Advanced));
      }

      private async Task NavigateToTricks(TrickLevel tricksLevel)
      {
         await Shell.Current.Navigation.PushAsync(new TricksPage());
      }
   }
}
