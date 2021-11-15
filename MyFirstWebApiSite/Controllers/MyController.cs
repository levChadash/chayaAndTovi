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
    public class MyController : ControllerBase
    {
        // GET: api/<MyController>
        [HttpGet]
        public string Get()
        {
            if(HttpContext.User.Identity.Name!=null)
            return HttpContext.User.Identity.Name;
            return "no!";
        }

        // GET api/<MyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
