using Microsoft.AspNetCore.Mvc;

using System.Net.Http;
using System.Threading.Tasks;

namespace BeginningToAsyncProgrammingV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public async Task<IActionResult> GetContentAsync()
        {
            var myTask = new HttpClient().GetStringAsync("https://www.google.com");



            var data = await myTask;

            return Ok(data);
        }
    }
}
