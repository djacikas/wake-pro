using Refit;
using WakeProApi.Models;

namespace WakeProApi.Services
{
   public interface ITricksClient
   {
      [Get("/items/tricks")]
      Task<Tricks> GetTricks();

      [Get("/items/tricks/{id}")]
      Task<TrickSingle> GetTrickById([AliasAs("id")] int trickId);

      [Get("/items/tricks?filter[name][_eq]={name}")]
      Task<Tricks> GetTricksByName([AliasAs("name")] string trickName);
   }
}
