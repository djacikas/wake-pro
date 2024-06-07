using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WakeProApi.Models;
using WakeProApi.Services;

namespace WakeProApi.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class AssetsController : ControllerBase
   {
      private readonly IContentClient _contentClient;

      public AssetsController(IContentClient contentClient)
      {
         _contentClient = contentClient;
      }

      [HttpGet("image/{id}")]
      public async Task<string> GetImageById(string id)
      {
         var response = await _contentClient.GetAssetById(id);
         
         return response;
      }

      [HttpGet("video/{id}")]
      public async Task<string> GetVideoById(string id)
      {
         var response = await _contentClient.GetAssetById(id);

         return response;
      }
   }
}
