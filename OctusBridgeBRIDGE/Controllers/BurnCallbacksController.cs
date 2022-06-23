using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OctusBridgeBRIDGE.Models.BurnCallback;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OctusBridgeBRIDGE.Controllers
{
#pragma warning disable CS1591
    [Route("burn_callbacks")]
    [ApiController]
    public class BurnCallbacksController : ControllerBase
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly IConfiguration _configuration;
        public BurnCallbacksController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Get burn callbacks data.
        /// </summary>
        /// <param name="model">BurnCallback Search Model</param>
        /// <returns></returns>
        [HttpPost]
        [Route("search")]
        public async Task<IActionResult> Search([Required][FromBody] BurnCallbackSearchModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"burn_callbacks/search");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<BurnCallbacksSearchResponseModel>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #region Helper
        private string ConstructRightUrl(string environment, string apiPathSuffix)
        {
            return environment + "/" + apiPathSuffix;
        }
        #endregion
    }
}
