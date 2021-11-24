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
        // GET: api/<DonorController>
        [HttpGet]
        public async Task<List<Donor>> getDonors()
        {
            return await dbl.getDonors();
        }

        // GET api/<DonorController>/5
        [HttpGet("{fn}/{ln}")]
        public async Task<List<Donor>> getDonor(string fn, string ln)
        {
            return await dbl.getDonor(fn, ln);
        }

        // POST api/<DonorController>
        [HttpPost]
        public async Task<bool> postDonor(Donor d)
        {
            return await dbl.postDonor(d);
        }

        // PUT api/<DonorController>/5
        [HttpPut("{d}")]
        public async Task<bool> putDonor(Donor d)
        {
            return await dbl.putDonor(d);
        }

        // DELETE api/<DonorController>/5
        [HttpDelete("{d}")]
        public async Task<bool> deleteDonor(Donor d)
        {
            return await dbl.deleteDonor(d);
        }
    }
}
