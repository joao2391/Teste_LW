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

        [HttpGet("getPf")]
        public async Task<IActionResult> GetPfCollection()
        {
            string pf = "pf";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }

        [HttpGet("getPj")]
        public async Task<IActionResult> GetPjCollection()
        {
            string pj = "pj";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }

        [HttpGet("getUniclass")]
        public async Task<IActionResult> GetUniclassCollection()
        {
            string uniclass = "UNICLA";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }

        [HttpGet("getITC")]
        public async Task<IActionResult> GetITCCollection()
        {
            string itc = "ITC";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }

        [HttpGet("getInternet")]
        public async Task<IActionResult> GetInternetCollection()
        {
            string internet = "internet";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }

        [HttpGet("getMobile")]
        public async Task<IActionResult> GetMobileCollection()
        {
            string mobile = "mobile";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }

        [HttpGet("getFaq")]
        public async Task<IActionResult> GetFaqCollection()
        {
            string faq = "faq";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }

        [HttpGet("getCard")]
        public async Task<IActionResult> GetCardCollection()
        {
            string card = "card";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }

        [HttpGet("getMenu")]
        public async Task<IActionResult> GetMenuCollection()
        {
            string menu = "menu";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }

        [HttpGet("getTrans")]
        public async Task<IActionResult> GetTransCollection()
        {
            string trans = "trans";
            string urlLW = "url_lw";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlLW);
            
            httpRequest.Headers.Add("Authorization",
                                    "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("username" + ":" + "password")));

            var httpResponse = await _client.SendAsync(httpRequest).Result.Content.ReadAsStringAsync();

            return Ok(httpResponse);

        }
        
    }
}
