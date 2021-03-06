using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApiSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class GroupController : ControllerBase
    {
        // GET: api/<GroupController>
      
        IGroupBL groupBL;

        public GroupController(IGroupBL groupBL)
        {
            this.groupBL = groupBL; ;
        }
        // GET: api/<GroupController>
     //   [EnableCors("AllowAll")]
        [HttpGet]
        public async Task<List<GroupDTO>> GetGroup()
        {
            return await groupBL.GetGroups();
        }

        //[HttpPost("login")]
        [AllowAnonymous]
        [HttpPost("teamHead")]
        public async Task<GroupDTO> GetGroupByPassword([FromBody] LoginTeamHeadDTO user)
        {
            return await groupBL.GetGroupByPassword(user.Password, user.TeamHeadName);
        }


        [HttpGet("groupNum/{groupNum}")]
        

        public async Task<GroupDTO> GetGroupByNum(int groupNum)
        {
            return await groupBL.GetGroupByNum(groupNum);
        }
        //GET api/<GroupController>/5

        [HttpGet("{id}")]
        public async Task<GroupDTO> GetGroupById(int id)
        {
            return await groupBL.GetGroupById(id);
        }

        [HttpGet("raises/{id}")]
        public async Task<List<RaiseDTO>> GetListOfRaisesInGroup(int id)
        {
            return await groupBL.GetListOfRaisesInGroup(id);
        }

        //[Route("[action]/{IdOfHead}")]
        [HttpGet("IdOfHead/{IdOfHead}")]

        public async Task<GroupDTO> GetGroupByIdOfHead(int IdOfHead)
        {
            return await groupBL.GetGroupByIdOfHead(IdOfHead);
        }

        // POST api/<GroupController>
        [HttpPost]
        public async Task<bool> PostGroup([FromBody] GroupDTO d)
        {
            return await groupBL.PostGroup(d);
        }

        // PUT api/<GroupController>/5
        [HttpPut("{id}")]
        public async Task<bool> PutGroup(int id,[FromBody] GroupDTO group)
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
