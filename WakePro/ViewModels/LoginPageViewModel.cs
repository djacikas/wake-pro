using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WakePro.ViewModels
{
   public partial class LoginPageViewModel : BaseViewModel
   {
      [ObservableProperty]
      private string _userName;
      
      [ObservableProperty]
      private string _password;

      [RelayCommand]
      public async void Login()
      {

      }
   }
}
