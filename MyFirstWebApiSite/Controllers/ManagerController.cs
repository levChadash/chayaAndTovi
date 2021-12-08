using BL;
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
    public class ManagerController : ControllerBase
    {
        IManagerBL Managerbl;

        public ManagerController(IManagerBL Managerbl)
        {
            this.Managerbl = Managerbl;
        }
        // GET: api/<Manager1Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Manager1Controller>/5
        [HttpGet("{ManagerName}/{password}")]
        public async Task<ActionResult<Manager>> Get(string ManagerName, string password)
        {

            Manager m = await Managerbl.GetManager(ManagerName, password);
            if (m != null)
                return m;
            return NoContent();
        }

        // POST api/<Manager1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Manager1Controller>/5
        [HttpPut("{ManagerName}/{password}/{NewPassword}")]
        public void Put(string ManagerName, string password, string NewPassword)
        {
            Managerbl.PutManager(ManagerName, password, NewPassword);
        }



        // DELETE api/<Manager1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
