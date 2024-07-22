using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WakePro.Models;
using WakePro.Services;
using WakePro.Views;

namespace WakePro.ViewModels
{
   public partial class LoginPageViewModel : BaseViewModel
   {
      [ObservableProperty]
      private string _userName;

      [ObservableProperty]
      private string _password;

      readonly ILoginRepository _loginRepository;

      public LoginPageViewModel(IConfiguration configuration)
      {
         _loginRepository = new LoginService(configuration);
      }

      [RelayCommand]
      public async void Login()
      {
         if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
         {
            UserInfo userInfo = await _loginRepository.Login(UserName, Password);

            if (Preferences.ContainsKey(nameof(App.UserInfo)))
            {
               Preferences.Remove(nameof(App.UserInfo));
            }

            string userDetails = JsonConvert.SerializeObject(userInfo);
            Preferences.Set(nameof(App.UserInfo), userDetails);
            App.UserInfo = userInfo;

            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
         }
      }
   }
}
