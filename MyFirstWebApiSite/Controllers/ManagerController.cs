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
        

        // GET api/<Manager1Controller>/5
        [HttpGet("{managerName}/{password}")]
        public async Task<Manager> Get(string managerName, string password)
        {

            Manager m = await Managerbl.GetManager(managerName, password);

            return m;
        }

        // POST api/<Manager1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Manager1Controller>/5
        [HttpPut("{managerName}/{password}/{newPassword}")]
        public void Put(string managerName, string password, string newPassword)
        {
            Managerbl.PutManager(managerName, password, newPassword);
        }



        // DELETE api/<Manager1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
