using System;
using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DL
{
    public class VisitDL : IVisitDL
    {
        DonationManagementContext dmc;
        ILogger<VisitDL> logger;
        public VisitDL(DonationManagementContext dmc, ILogger<VisitDL> logger )
        {
            this.dmc = dmc;
            this.logger = logger;
        }
        public async Task<List<DonorsVisit>> GetDonorsVisits()
        {
            List<DonorsVisit> lv = await dmc.DonorsVisits.Include(v => v.Donor).Include(v => v.Group).Include(v => v.PreferredTime).Include(v => v.Status).ToListAsync();
            return lv;
        }

        public async Task<List<RisingVisit>> GetRaisesVisits()
        {
            List<RisingVisit> lv = await dmc.RisingVisits.ToListAsync();
            return lv;
        }

        public async Task<List<DonorsVisit>> GetVisitsByGroup(int id)
        {
            List<DonorsVisit> lv = await dmc.DonorsVisits.Where(v => v.Group.Id == id&&v.Status.Happen==false).Include(v=>v.Donor).ThenInclude(d=>d.Contact).Include(v => v.Group).Include(v => v.PreferredTime).Include(v => v.Status).ToListAsync();//
            return lv;
        }
        public async Task<List<DonorsVisit>> GetListOfVisitsByRaise(int id, int year)
        {
            try
            {
                List<RisingVisit> lrv = await dmc.RisingVisits.Where(d => d.RaiseId == id).ToListAsync();
                List<DonorsVisit> ldv = new List<DonorsVisit>();
                lrv.ForEach(rv =>
               {
                   var x = dmc.DonorsVisits.Where(v => rv.VisitId == v.Id && v.year == year).FirstOrDefault();
                   ldv.Add(x);
               });
                return ldv;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }
            return null;
        }


        public async Task<DonorsVisit> GetDonorVisit(int id, int year)
        {
            DonorsVisit d = await dmc.DonorsVisits.Where(d => d.DonorId == id && d.year == year).FirstOrDefaultAsync();
            return d;
        }

        public async Task<List<DonorsVisit>> GetDonorsVisitsByYear(int year)
        {
            List<DonorsVisit> ld = await dmc.DonorsVisits.Where(d => d.year == year).Include(d=>d.Donor).ToListAsync();
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
