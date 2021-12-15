using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApiSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassageController : ControllerBase
    {
        IMassageBL massageBL;

        public MassageController(IMassageBL massageBL)
        {
            this.massageBL = massageBL; ;
        }
        // GET: api/<MassageController>
        [HttpGet]
        public async Task<List<Massage>> GetAsync()
        {
            return await massageBL.GetAllMassages();
        }

        [HttpGet("groupId/{groupId}")]
        public async Task<List<Massage>> GetMassagesByGroupId(int groupId )
        {
            return await massageBL.GetMassagesByGroupId(groupId);
        }
        [HttpGet("{id}/massages")]
        public async Task<Massage> GetMassagesById(int id)
        {
            return await massageBL.GetMassagesById(id);
        }

        // POST api/<MassageController>
        [HttpPost]
        public async Task<int> Post([FromBody] Massage massage)
        {
            return await massageBL.Post(massage);
        }

        [HttpPost("text/{text}")]
        public async Task<int> PostText(string text)
        {
            return await massageBL.PostText(text);
        }

        // DELETE api/<MassageController>/5
        [HttpDelete]
        public async Task<bool> Delete()
        {
            return await massageBL.Delete();
        }

        // DELETE api/<MassageController>/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(int id)
        {
            return await massageBL.DeleteById(id);
        }
    }
}
