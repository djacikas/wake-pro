using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WakePro.Models;

namespace WakePro.Services
{
   public class LoginService : ILoginRepository
   {
      public Task<UserInfo> Login(string username, string password)
      {
         throw new NotImplementedException();
      }
   }
}
