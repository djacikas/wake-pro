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
      private readonly ITricksAPI _tricksAPI;

      public TricksController(ITricksAPI tricksAPI)
      {
         _tricksAPI = tricksAPI;
      }

      [HttpGet(Name = "GetTricks")/*, Authorize*/]
      public Task<TricksList> Get()
      {
         var response = _tricksAPI.GetTricks();

         return response;
      }
   }
}
