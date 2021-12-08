using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
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
            return await groupBL.GetGroups();
        }

        [HttpGet("{groupNum}")]
        //[Route("[action]/{GroupNum}")]

        public async Task<Group> GetGroupByNum(int groupNum)
        {
            return await groupBL.GetGroupByNum(groupNum);
        }
        //GET api/<GroupController>/5

        [HttpGet("{id}")]
        public async Task<Group> GetGroupById(int id)
        {
            return await groupBL.GetGroupById(id);
        }

        [HttpGet("{id}")]
        public async Task<List<Raise>> GetListOfRaisesInGroup(int id)
        {
            return await groupBL.GetListOfRaisesInGroup(id);
        }

        //[Route("[action]/{IdOfHead}")]
        [HttpGet("{IdOfHead}")]

        public async Task<Group> GetGroupByIdOfHead(int id)
        {
            return await groupBL.GetGroupByIdOfHead(id);
        }

        // POST api/<GroupController>
        [HttpPost]
        public async Task<bool> PostGroup([FromBody] Group d)
        {
            return await groupBL.PostGroup(d);
        }

        // PUT api/<GroupController>/5
        [HttpPut("{id}")]
        public async Task<bool> PutGroup(int id,[FromBody] Group group)
        {
            return await groupBL.PutGroup(id, group);
        }

        // DELETE api/<GroupController>/5
        [HttpDelete("{IdOfHead}")]
        public async Task<bool> DeleteGroup(int IdOfHead)
        {
            return await groupBL.DeleteGroup(IdOfHead);
        }
    }
}
