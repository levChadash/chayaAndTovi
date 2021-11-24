using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApiSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaiseController : ControllerBase
    {
        // GET: api/<RaiseController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RaiseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RaiseController>
        [HttpPost]
        public void Post([FromBody] Raise raise)
        {
        }

        // PUT api/<RaiseController>/5
        [HttpPut()]
        public void Put( [FromBody] Raise raise)
        {

        }

        // DELETE api/<RaiseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
