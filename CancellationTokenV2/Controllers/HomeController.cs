using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CancellationTokenWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetContentAsync(CancellationToken token)
        {
            
            try
            {
                _logger.LogInformation("İstek başladı");

                await Task.Delay(5000, token);

                Enumerable.Range(1,10).ToList().ForEach(x =>
                {
                    Thread.Sleep(1000);

                    token.ThrowIfCancellationRequested();
                });

                //var myTask = new HttpClient().GetAsync("https://www.google.com");

                //var data = myTask.Result;

                _logger.LogInformation("İstek bitti");

                return Ok();
            }
            catch (TaskCanceledException exception)
            {
                _logger.LogInformation("İstek iptal edildi : "+exception.Message);
                return BadRequest();
            }
        }
    }
}
