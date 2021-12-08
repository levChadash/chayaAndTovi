using DL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class VisitBL : IVisitBL
    {
        IVisitDL visitDL;
        public VisitBL(IVisitDL visitDL)
        {
            this.visitDL = visitDL;
        }

        public async Task<List<DonorsVisit>> GetDonorsVisits()
        {
            return await visitDL.GetDonorsVisits();
        }

        public async Task<List<RisingVisit>> GetRaisesVisits()
        {
            return await visitDL.GetRaisesVisits();
        }
        public async Task<List<DonorsVisit>> GetListOfVisitsByRaise(int id, int year)
        {
            return await visitDL.GetListOfVisitsByRaise(id, year);
        }


        public async Task<DonorsVisit> GetDonorVisit(int id, int year)
        {
            return await visitDL.GetDonorVisit(id, year);
        }

        public async Task<List<DonorsVisit>> GetDonorsVisitsByYear(int year)
        {
            return await visitDL.GetDonorsVisitsByYear(year);
        }

        public async Task<bool> PostDonorVisit(DonorsVisit dv)
        {
            return await visitDL.PostDonorVisit(dv);
        }

        public async Task<bool> PostRaiseVisit(RisingVisit rv)
        {
            return await visitDL.PostRaiseVisit(rv);
        }
        public async Task<bool> PutDonorVisit(int id, DonorsVisit dv)
        {
            return await visitDL.PutDonorVisit(id, dv);
        }

        public async Task<bool> PutRaiseVisit(int id, RisingVisit rv)
        {
            return await visitDL.PutRaiseVisit(id, rv);
        }
        public async Task<bool> DeleteDonorVisit(int id, int year)
        {
            return await visitDL.DeleteDonorVisit(id, year);
        }


    }
}
