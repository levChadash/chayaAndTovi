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
    public class RaiseController : ControllerBase
    {
        // GET: api/<RaiseController>
            IRaiseBL raiseBL;

            public RaiseController(IRaiseBL raiseBL)
            {
                this.raiseBL = raiseBL; ;
            }
        // GET: api/<RaiseController>
        [HttpGet]
            public async Task<List<Raise>> GetRaise()
            {
                return await raiseBL.GetRaise();
            }

        // GET api/<RaiseController>/5
        [HttpGet("{fn}/{ln}")]
            public async Task<List<Raise>> GetRaise(string fn, string ln)
            {
                return await raiseBL.GetRaise(fn, ln);
            }
        // GET api/<RaiseController>/5
        [HttpGet("{idNumber}")]
        public async Task<Raise> GetRaise(string idNumber)
        {
            return await raiseBL.GetRaise(idNumber);
        }

        // POST api/<DonorController>
        [HttpPost]
            public async Task<bool> PostRaise([FromBody] Raise d)
            {
                return await raiseBL.PostRaise(d);
            }

        // PUT api/<RaiseController>/5
        [HttpPut]
            public async Task<bool> PutRaise( [FromBody] Raise raise)
            {
                return await raiseBL.PutRaise(raise);
            }

        // DELETE api/<RaiseController>/5
        [HttpDelete("{id}")]
            public async Task<bool> DeleteRaise(int id)
            {
                return await raiseBL.DeleteRaise(id);
            }
        }
}
