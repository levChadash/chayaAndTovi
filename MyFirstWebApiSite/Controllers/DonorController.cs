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
    public class DonorController : ControllerBase
    {
        IDonorBL dbl;

        public DonorController(IDonorBL dbl)
        {
            this.dbl = dbl; ;
        }
        // GET: api/<DonorController>
        [HttpGet]
        public async Task<List<Donor>> GetDonors()
        {
            return await dbl.GetDonors();
        }

        // GET api/<DonorController>/5
        [HttpGet("{fn}/{ln}")]
        public async Task<List<Donor>> GetDonor(string fn, string ln)
        {
            return await dbl.GetDonor(fn, ln);
        }

        [HttpGet("{id}")]
        public async Task<Donor> GetDonorById(int id)
        {
            return await dbl.GetDonorById(id);
        }

        // POST api/<DonorController>
        [HttpPost]
        public async Task<bool> PostDonor([FromBody] Donor d)
        {
            return await dbl.PostDonor(d);
        }

        // PUT api/<DonorController>/5
        [HttpPut("{id}")]
        public async Task<bool> PutDonor(int id ,[FromBody] Donor d)
        {
            return await dbl.PutDonor(id,d);
        }

        // DELETE api/<DonorController>/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteDonor(int id)
        {
            return await dbl.DeleteDonor(id);
        }
    }
}
