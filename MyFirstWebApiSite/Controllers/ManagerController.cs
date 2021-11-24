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
    public class ManagerController : ControllerBase
    {
        IUserBL userbl;
        public ManagerController(IUserBL userbl)
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
        [HttpGet("{ManagerName}/{password}")]
        public async Task< ActionResult<user>> Get(string ManagerName, string password)
        {
           
            Manager m = await userbl.getUser(ManagerName, password);
            if (u!=null)
                return u;
            return NoContent();
        }

        //// POST api/<user>
        //[HttpPost]
        //public async Task<user> Post([FromBody] user u)

        //{
        //    return await userbl.postUser(u);
        //}

        //// PUT api/<user>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] user u)
        //{
        //  userbl.putUser(id, u);
        //}

        //// DELETE api/<user>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
