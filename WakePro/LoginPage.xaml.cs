using WakePro.ViewModels;

namespace WakePro;

public partial class LoginPage : ContentPage
{
   public LoginPage(LoginPageViewModel loginPageViewModel)
   {
      InitializeComponent();
      this.BindingContext = loginPageViewModel;
   }
}