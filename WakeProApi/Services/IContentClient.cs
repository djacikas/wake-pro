using Refit;
using WakeProApi.Models;

namespace WakeProApi.Services
{
   public interface IContentClient : ITricksClient, IAssetsClient
   {
   }
}
