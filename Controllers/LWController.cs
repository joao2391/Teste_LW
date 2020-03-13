using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace LW.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/collection")]
    public class LWController : ControllerBase
    {       
        private readonly ILogger<WeatherForecastController> _logger;
        private HttpClient _client;        

        public LWController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _client = new HttpClient();
        }

        [HttpGet("get/{collection}")]        
        public async Task<IActionResult> GetCollections(string collection)
        {            
            string urlLW = "url_lw"; 
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);
        }
        
        [HttpGet("getVarejo")]
        public async Task<IActionResult> GetVarejoCollection()
        {
            string varejo = "VAREJO";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }
        
    }
}
