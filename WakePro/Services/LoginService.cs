using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using WakePro.Models;

namespace WakePro.Services
{
   public class LoginService : ILoginRepository
   {
      private readonly IConfiguration _configuration;

      public LoginService(IConfiguration configuration)
      {
         _configuration = configuration;
      }

      public async Task<UserInfo> Login(string username, string password)
      {
         try
         {
            if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
            {
               var userInfo = new UserInfo();
               var client = new HttpClient();

               var baseApiUrl = _configuration.GetRequiredSection("ApiUrls").GetValue<string>("Base");
               var loginUrl = _configuration.GetRequiredSection("ApiUrls").GetValue<string>("Login");
               string url = baseApiUrl + loginUrl;
               client.BaseAddress = new Uri(url);

               var postData = new
               {
                  email = username,
                  password = password
               };

               var json = JsonConvert.SerializeObject(postData);
               var content = new StringContent(json, Encoding.UTF8, "application/json");

               HttpResponseMessage response = await client.PostAsync(url, content);
               if (response.IsSuccessStatusCode)
               {
                  userInfo = await response.Content.ReadFromJsonAsync<UserInfo>();
                  return await Task.FromResult(userInfo);
               }
               else
               {
                  return null;
               }
            }
            else
            {
               return null;
            }
         }
         catch (Exception ex)
         {
            throw ex.InnerException;
         }
      }
   }
}
