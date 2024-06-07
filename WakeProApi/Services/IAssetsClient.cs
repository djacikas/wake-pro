using Refit;
using WakeProApi.Models;

namespace WakeProApi.Services
{
   public interface IAssetsClient
   {
      [Get("/assets/{id}")]
      Task<string> GetAssetById([AliasAs("id")] string id);
   }
}
