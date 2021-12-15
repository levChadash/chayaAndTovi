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
    public class VisitController : ControllerBase
    {
        IVisitBL visitbl;

        public VisitController(IVisitBL visitbl)
        {
            this.visitbl = visitbl; ;
        }

        // GET: api/<VisitController>
        [HttpGet]
        public async Task<List<DonorsVisit>> GetDonorsVisits()
        {
            return await visitbl.GetDonorsVisits();
        }
        [HttpGet]
        public async Task<List<RisingVisit>> GetRaisesVisits()
        {
            return await visitbl.GetRaisesVisits();
        }
        [HttpGet("{id}/{year}")]
        public async Task<List<DonorsVisit>> GetListOfVisitsByRaise(int id, int year)
        {
            return await visitbl.GetListOfVisitsByRaise(id, year);
        }

        [HttpGet("{id}/{year}")]
        public async Task<DonorsVisit> GetDonorVisit(int id, int year)
        {
            return await visitbl.GetDonorVisit(id, year);
        }
        [HttpGet("{id}")]
        public async Task<List<DonorsVisit>> GetDonorsVisitsByYear(int year)
        {
            return await visitbl.GetDonorsVisitsByYear(year);
        }
        [HttpPost]
        public async Task<bool> PostDonorVisit(DonorsVisit dv)
        {
            return await visitbl.PostDonorVisit(dv);
        }
        [HttpPost]
        public async Task<bool> PostRaiseVisit(RisingVisit rv)
        {
            return await visitbl.PostRaiseVisit(rv);
        }
        [HttpPut("{id}/{dv}")]
        public async Task<bool> PutDonorVisit(int id, DonorsVisit dv)
        {
            return await visitbl.PutDonorVisit(id, dv);
        }
        [HttpPut("{id}/{rv}")]
        public async Task<bool> PutRaiseVisit(int id, RisingVisit rv)
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
