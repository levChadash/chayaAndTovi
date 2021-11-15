using BL;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApiSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        IUserBL userbl;
        public userController(IUserBL userbl)
        {
            this.userbl = userbl;
        }
        
        // GET: api/<user>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<user>/5
        [HttpGet("{email}/{password}")]
        public ActionResult<user> Get(string email, string password)
        {
           
            user u = userbl.getUser(email, password);
            if (u!=null)
                return u;
            return NoContent();
        }

        // POST api/<user>
        [HttpPost]
        public user Post([FromBody] user u)

        {
            return userbl.postUser(u);
        }

        // PUT api/<user>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] user u)
        {
          userbl.putUser(id, u);
        }

        // DELETE api/<user>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
