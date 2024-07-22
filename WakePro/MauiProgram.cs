using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;
using WakePro.ViewModels;
using WakePro.Views;

namespace WakePro
{
   public static class MauiProgram
   {
      public static MauiApp CreateMauiApp()
      {
         var builder = MauiApp.CreateBuilder();
         builder
           .UseMauiApp<App>()
           .ConfigureFonts(fonts =>
           {
              fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
              fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
           });

#if DEBUG
         builder.Logging.AddDebug();
#endif

         using var stream = Assembly.GetExecutingAssembly()
            .GetManifestResourceStream("WakePro.appsettings.json");
         var config = new ConfigurationBuilder().AddJsonStream(stream).Build();
         builder.Configuration.AddConfiguration(config);

         builder.Services.AddSingleton<LoginPage>();
         builder.Services.AddSingleton<HomePage>();

         builder.Services.AddSingleton<LoginPageViewModel>();

         return builder.Build();
      }
   }
}
