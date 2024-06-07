using Refit;
using WakeProApi.Models;

namespace WakeProApi.Services
{
   public interface ITricksAPI
   {
      [Get("/items/tricks")]
      Task<TricksList> GetTricks();
   }
}
