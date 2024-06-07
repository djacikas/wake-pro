using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WakeProApi.Models;
using WakeProApi.Services;

namespace WakeProApi.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class TricksController : ControllerBase
   {
      private readonly IContentClient _contentClient;

      public TricksController(IContentClient contentClient)
      {
         _contentClient = contentClient;
      }

      [HttpGet/*, Authorize*/]
      public async Task<IEnumerable<Trick>> GetTricks()
      {
         var response = await _contentClient.GetTricks();

         return response.Data;
      }

      [HttpGet("id/{trickId}")]
      public async Task<Trick> GetTrickById(int trickId)
      {
         //var response = _tricksAPI.GetTrickById(trickId).ConfigureAwait(false).GetAwaiter().GetResult();
         var response = await _contentClient.GetTrickById(trickId);
         
         return response.Data;
      }

      [HttpGet("name/{trickName}")]
      public async Task<IEnumerable<Trick>> GetTricksByName(string trickName)
      {
         var response = await _contentClient.GetTricksByName(trickName);

         return response.Data;
      }
   }
}
