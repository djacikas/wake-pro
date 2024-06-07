using Microsoft.AspNetCore.Mvc;
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

      [HttpGet("images/{id}")]
      public async Task<IActionResult> GetImageById(string id)
      {
         var response = await _contentClient.GetAssetById(id);

         if (response.IsSuccessStatusCode)
         {
            var stream = await response.Content.ReadAsStreamAsync();
            return new FileStreamResult(stream, "image/jpeg");
         }

         return StatusCode((int)response.StatusCode);
      }

      [HttpGet("videos/{id}")]
      public async Task<IActionResult> GetVideoById(string id)
      {
         var response = await _contentClient.GetAssetById(id);

         if (response.IsSuccessStatusCode)
         {
            var stream = await response.Content.ReadAsStreamAsync();
            return new FileStreamResult(stream, "video/mp4");
         }

         return StatusCode((int)response.StatusCode);

      }
   }
}
