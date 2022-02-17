using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Entity;
using DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApiSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitController : ControllerBase
    {
        IVisitBL visitbl;

        public VisitController(IVisitBL visitbl)
        {
            this.visitbl = visitbl; ;
        }

        // GET: api/<VisitController>
        [HttpGet("donors")]
        public async Task<List<DonorsVisitDTO>> GetDonorsVisits()
        {
            return await visitbl.GetDonorsVisits();
        }
        [HttpGet("raises")]
        public async Task<List<RisingVisitDTO>> GetRaisesVisits()
        {
            return await visitbl.GetRaisesVisits();
        }
        [HttpGet("raise/{id}/{year}")]
        public async Task<List<DonorsVisitDTO>> GetListOfVisitsByRaise(int id, int year)
        {
            return await visitbl.GetListOfVisitsByRaise(id, year);
        }

        [HttpGet("donor/{id}/{year}")]
        public async Task<DonorsVisitDTO> GetDonorVisit(int id, int year)
        {
            return await visitbl.GetDonorVisit(id, year);
        }
        [HttpGet("{year}")]
        public async Task<List<DonorsVisitDTO>> GetDonorsVisitsByYear(int year)
        {
            return await visitbl.GetDonorsVisitsByYear(year);
        }
        [HttpGet("group/{GroupId}")]
        public async Task<List<VisitDTO>> GetDonorsVisitsByGroupId(int GroupId)
        {
            return await visitbl.GetDonorsVisitsByGroupId(GroupId);
        }
        [HttpPost("donor")]
        public async Task<bool> PostDonorVisit([FromBody] DonorsVisitDTO dv)
        {
            return await visitbl.PostDonorVisit(dv);
        }
        [HttpPost("raise")]
        public async Task<bool> PostRaiseVisit([FromBody] RisingVisitDTO rv)
        {
            return await visitbl.PostRaiseVisit(rv);
        }
        [HttpPut("Donors/{id}")]
        public async Task<bool> PutDonorVisit(int id, [FromBody] DonorsVisitDTO dv)
        {
            return await visitbl.PutDonorVisit(id, dv);
        }
        [HttpPut("Raises/{id}")]
        public async Task<bool> PutRaiseVisit(int id, [FromBody] RisingVisitDTO rv)
        {
            return await visitbl.PutRaiseVisit(id, rv);
        }
        [HttpDelete("{id}/{year}")]
        public async Task<bool> DeleteDonorVisit(int id, int year)
        {
            return await visitbl.DeleteDonorVisit(id, year);
        }



    }
}
