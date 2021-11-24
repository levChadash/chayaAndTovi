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

        // POST api/<DonorController>
        [HttpPost]
        public async Task<bool> PostDonor(Donor d)
        {
            return await dbl.PostDonor(d);
        }

        // PUT api/<DonorController>/5
        [HttpPut("{d}")]
        public async Task<bool> PutDonor(Donor d)
        {
            return await dbl.PutDonor(d);
        }

        // DELETE api/<DonorController>/5
        [HttpDelete("{d}")]
        public async Task<bool> DeleteDonor(Donor d)
        {
            return await dbl.DeleteDonor(d);
        }
    }
}
