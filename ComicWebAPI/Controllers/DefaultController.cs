using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace ComicWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        // GET: api/Default
        [HttpGet]
        [EnableCors]
        public async Task<string> Get()
            
        {
            var hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("user-agent", "Only a test!");
            var url = "https://comicvine.gamespot.com/api/issues/?api_key=6501e49837b61d47f4bb33508909218856619457&format=json&filter=name:Walking Dead";
            return await hc.GetStringAsync(url);
        }

        // GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Default/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
