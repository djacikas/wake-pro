using WakePro.ViewModels;

namespace WakePro.Views;

public partial class TricksPage : ContentPage
{
   public TricksPage()
   {
      InitializeComponent();
      BindingContext = new TricksPageViewModel();
   }
}