using System;
using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DL
{
    public class VisitDL : IVisitDL
    {
        DonationManagementContext dmc;
        public VisitDL(DonationManagementContext dmc)
        {
            this.dmc = dmc;
        }
        public async Task<List<DonorsVisit>> GetDonorsVisits()
        {
            List<DonorsVisit> lv = await dmc.DonorsVisits.ToListAsync();
            return lv;
        }

        public async Task<List<RisingVisit>> GetRaisesVisits()
        {
            List<RisingVisit> lv = await dmc.RisingVisits.ToListAsync();
            return lv;
        }
        public async Task<List<DonorsVisit>> GetListOfVisitsByRaise(int id, int year)
        {

            List<RisingVisit> lrv = await dmc.RisingVisits.Where(d => d.RaiseId == id).ToListAsync();
            List<DonorsVisit> ldv = new List<DonorsVisit>();
            lrv.ForEach(async d =>
            {
                ldv.Add(await dmc.DonorsVisits.Where(v => d.VisitId == v.Id && v.year == year).FirstOrDefaultAsync());
            });
            return ldv;
        }


        public async Task<DonorsVisit> GetDonorVisit(int id, int year)
        {
            DonorsVisit d = await dmc.DonorsVisits.Where(d => d.DonorId == id && d.year == year).FirstOrDefaultAsync();
            return d;
        }

        public async Task<List<DonorsVisit>> GetDonorsVisitsByYear(int year)
        {
            List<DonorsVisit> ld = await dmc.DonorsVisits.Where(d => d.year == year).ToListAsync();
            return ld;
        }

        public async Task<bool> PostDonorVisit(DonorsVisit dv)
        {
            await dmc.DonorsVisits.AddAsync(dv);
            await dmc.SaveChangesAsync();
            return true;
        }

        public async Task<bool> PostRaiseVisit(RisingVisit rv)
        {
            await dmc.RisingVisits.AddAsync(rv);
            await dmc.SaveChangesAsync();
            return true;
        }
        public async Task<bool> PutDonorVisit(int id, DonorsVisit dv)
        {
            var d2 = await dmc.DonorsVisits.FindAsync(id);
            if (d2 == null)
                return false;
            dmc.Entry(d2).CurrentValues.SetValues(dv);
            await dmc.SaveChangesAsync();
            return true;
        }

        public async Task<bool> PutRaiseVisit(int id, RisingVisit rv)
        {
            var d2 = await dmc.RisingVisits.FindAsync(id);
            if (d2 == null)
                return false;
            dmc.Entry(d2).CurrentValues.SetValues(rv);
            await dmc.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteDonorVisit(int id, int year)
        {
            var donorV = await GetDonorVisit(id, year);
            if (donorV == null)
                return false;
            dmc.DonorsVisits.Remove(donorV);
            await dmc.SaveChangesAsync();
            return true;
        }
    }
}
