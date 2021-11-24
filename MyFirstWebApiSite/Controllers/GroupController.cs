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
    public class GroupController : ControllerBase
    {
        // GET: api/<GroupController>
      
        IGroupBL groupBL;

        public GroupController(IGroupBL groupBL)
        {
            this.groupBL = groupBL; ;
        }
        // GET: api/<GroupController>
        [HttpGet]
        public async Task<List<Group>> GetGroup()
        {
            return await groupBL.GetGroup();
        }

        // GET api/<GroupController>/5
        [HttpGet("{fn}/{ln}")]
        public async Task<List<Group>> GetGroup(string fn, string ln)
        {
            return await groupBL.GetGroup(fn, ln);
        }
        // GET api/<GroupController>/5
        [HttpGet("{idNumber}")]
        public async Task<Group> GetGroup(string idNumber)
        {
            return await groupBL.GetGroup(idNumber);
        }

        // POST api/<GroupController>
        [HttpPost]
        public async Task<bool> PostGroup([FromBody] Group d)
        {
            return await groupBL.PostGroup(d);
        }

        // PUT api/<GroupController>/5
        [HttpPut]
        public async Task<bool> PutGroup([FromBody] Group group)
        {
            return await groupBL.PutGroup(group);
        }

        // DELETE api/<GroupController>/5
        [HttpDelete("{idNumber}")]
        public async Task<bool> DeleteRaise(string idNumber)
        {
            return await groupBL.DeleteRaise(idNumber);
        }
    }
}
