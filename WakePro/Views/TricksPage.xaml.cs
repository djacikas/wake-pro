using WakePro.ViewModels;

namespace WakePro.Views;

public partial class TricksPage : ContentPage
{
   public TricksPage()
   {
      InitializeComponent();
      //TODO: check if this could be a singleton, how it interacts when multiple users are logged in
      BindingContext = new TricksPageViewModel();
   }
}