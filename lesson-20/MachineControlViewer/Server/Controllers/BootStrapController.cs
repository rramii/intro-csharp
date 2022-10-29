using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MachineControlViewer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootStrapController : ControllerBase
    {
        // GET: api/<BootStrapController>
        [HttpGet]
        public ActionResult Get()
        {
            var s = new Services.BootStrapService();
            s.initialize();
            return Ok();
        }

        // GET api/<BootStrapController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BootStrapController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BootStrapController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BootStrapController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
