using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OctusBridgeBRIDGE.Models.Dao;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OctusBridgeBRIDGE.Controllers
{
#pragma warning disable CS1591
    [Route("dao")]
    [ApiController]
    public class DaoController : ControllerBase
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly IConfiguration _configuration;
        public DaoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Get stakeholders data.
        /// </summary>
        /// <param name="model">SearchDaoStakeholdersModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("search/stakeholders")]
        public async Task<IActionResult> Search([Required][FromBody] SearchDaoStakeholdersModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"dao/search/stakeholders");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<StakeholdersDaoResponseModel>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get stakeholder data.
        /// </summary>
        /// <param name="user_address">user_address</param>
        /// <returns></returns>
        [HttpPost]
        [Route("user/{user_address}")]
        public async Task<IActionResult> StakeholderData([Required] string user_address)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string apiEndpoint = ConstructRightUrl(baseUrl, $"dao/user/{user_address}");
                HttpResponseMessage response = await _httpClient.GetAsync(apiEndpoint);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<StakeholderDaoHelperModel>(jsonResponse);
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
