using AngularWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AngularWebsite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IATAOneRecordController : ControllerBase
    {
        private readonly HttpClient _client;

        public IATAOneRecordController(HttpClient client) => _client = client;

        [HttpGet]
        public async Task<ActionResult<IATAOneRecord[]>> Get()
        {
            var response = await _client.GetAsync("https://iatahackathon-cargo.aircanada.com/");

            if(response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync(); 
                var data = JsonConvert.DeserializeObject<IATAOneRecord>(content);
                var iataonerecords = new List<IATAOneRecord>();
                iataonerecords.Add(data);
                return Ok(iataonerecords);
            }

            return BadRequest("Unable to retrieve data.");
        }
    }
}
