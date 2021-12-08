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
    public class MassageController : ControllerBase
    {
        IMassageBL MassageBL;

        public GroupController(IGroupBL groupBL)
        {
            this.groupBL = groupBL; ;
        }
        // GET: api/<MassageController>
        [HttpGet]
        public async Task<List<Massage>> GetAllMassages()
        {
            return async GetAllMassages();
        }

        // GET api/<MassageController>/5
        [HttpGet("{groupId}")]
        public async Task<List<Massage>> GetMassagesByGroupId(int groupId )
        {
            return async GetMassagesByGroupId(groupId);
        }

        // POST api/<MassageController>
        [HttpPost]
        public async Task<int> Post([FromBody] string value)
        {
            return async Post(value);
        }



        // DELETE api/<MassageController>/5
        [HttpDelete]
        public async Task<bool> Delete()
        {
            return async Delete();
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeleteById(int id)
        {
            return async DeleteById(id);
        }
    }
}
