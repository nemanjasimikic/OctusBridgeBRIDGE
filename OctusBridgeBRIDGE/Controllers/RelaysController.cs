using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OctusBridgeBRIDGE.Models.Relay;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OctusBridgeBRIDGE.Controllers
{
#pragma warning disable CS1591
    [Route("relays_pages")]
    [ApiController]
    public class RelaysController : ControllerBase
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly IConfiguration _configuration;
        public RelaysController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Get relay info.
        /// </summary>
        /// <param name="model">RelayInfoRequestModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("relay_info")]
        public async Task<IActionResult> RelayInfo([Required][FromBody] RelayInfoRequestModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"relays_pages/relay_info");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RelayInfoResponseModel>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get relay round info.
        /// </summary>
        /// <param name="model">RelayRoundRequestModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("relay_round_info")]
        public async Task<IActionResult> RelayRoundInfo([Required][FromBody] RelayRoundRequestModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"relays_pages/relay_round_info");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RelayRoundResponseModel>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get relays round info.
        /// </summary>
        /// <param name="model">RelaysRoundRequestModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("relays_round_info")]
        public async Task<IActionResult> RelaysRoundInfo([Required][FromBody] RelaysRoundRequestModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"relays_pages/relays_round_info");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RelaysRoundResponseModel>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get all relays rounds info.
        /// </summary>
        /// <param name="model">AllRelaysRoundsRequestModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("all_relay_rounds_info")]
        public async Task<IActionResult> AllRelaysRoundsInfo([Required][FromBody] AllRelaysRoundsRequestModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"relays_pages/all_relay_rounds_info");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<AllRelaysRoundsResponseModel>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get round info.
        /// </summary>
        /// <param name="model">RoundInfoRequestModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("round_info")]
        public async Task<IActionResult> RoundInfo([Required][FromBody] RoundInfoRequestModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"relays_pages/round_info");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RoundInfoResponseModel>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get relays.
        /// </summary>
        /// <param name="model">SearchRelaysModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("search/relays")]
        public async Task<IActionResult> SearchRelays([Required][FromBody] SearchRelaysModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"relays_pages/search/relays");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SearchRelaysResponseModel>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get relays's events.
        /// </summary>
        /// <param name="model">SearchRelaysEventsModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("search/relays_events")]
        public async Task<IActionResult> SearchRelaysEvents([Required][FromBody] SearchRelaysEventsModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"relays_pages/search/relays_events");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SearchRelaysEventsResponseModel>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Global relays's events search.
        /// </summary>
        /// <param name="model">SearchGlobalRelaysEventsModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("search/global_relays_events")]
        public async Task<IActionResult> SearchGlobalRelaysEvents([Required][FromBody] SearchGlobalRelaysEventsModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"relays_pages/search/global_relays_events");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SearchGlobalRelaysEventsResponseModel>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get round's calendar.
        /// </summary>
        /// <param name="model">RoundsCalendarRequestModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("rounds_calendar")]
        public async Task<IActionResult> RoundsCalendar([Required][FromBody] RoundsCalendarRequestModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"relays_pages/rounds_calendar");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<RoundsCalendarResponseModel>>(jsonResponse);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Get relay rounds info.
        /// </summary>
        /// <param name="model">RelayRoundsInfoRequestModel</param>
        /// <returns></returns>
        [HttpPost]
        [Route("relay_rounds_info")]
        public async Task<IActionResult> RoundsCalendar([Required][FromBody] RelayRoundsInfoRequestModel model)
        {
            try
            {
                var baseUrl = _configuration["BaseUrl"];
                string json = System.Text.Json.JsonSerializer.Serialize(model);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                string apiEndpoint = ConstructRightUrl(baseUrl, $"relays_pages/relay_rounds_info");
                HttpResponseMessage response = await _httpClient.PostAsync(apiEndpoint, data);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RelayRoundsInfoResponseModel>(jsonResponse);
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
