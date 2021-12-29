using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
   public class RaiseDL : IRaiseDL
    {

        DonationManagementContext dmc;
        public RaiseDL(DonationManagementContext dmc)
        {
            this.dmc = dmc;
        }
        public async Task<List<Raise>> GetRaise()
        {
            List<Raise> raises = await dmc.Raises.ToListAsync();
            return raises;
        }
        public async Task<List<Raise>> GetRaise(string fn, string ln)
        {
            List<Raise> ld = await dmc.Raises.Where(d => d.FirstName == fn && d.LastName == ln).ToListAsync();
            return ld;
        }

        public async Task<Raise> GetRaiseById(int id)
        {
            Raise d = await dmc.Raises.FindAsync(id);
            return d;
        }
        public async Task<Raise> GetRaise(string idNumber)
        {
            var raise = await dmc.Raises.SingleOrDefaultAsync(d => d.IdNumber == idNumber);
            return raise;
        }

        public async Task<List<DonorsVisit>> GetListOfVisitsByRaise(int id, int year)
        {

                List<RisingVisit> lrv = await dmc.RisingVisits.Where(d => d.Id == id).ToListAsync();
                List<DonorsVisit> ldv = new List<DonorsVisit>();
                lrv.ForEach(rv =>
                {
                    var x = dmc.DonorsVisits.Where(v => rv.VisitId == v.Id && v.year == year).FirstOrDefault();
                    ldv.Add(x);
                });
                return ldv;
            
            return null;
        }
        public async Task<bool> PostRaise(Raise raise)
        {
            await dmc.Raises.AddAsync(raise);
            await dmc.SaveChangesAsync();
            return true;
        }
        public async Task<bool> PutRaise(Raise raise)
        {
            var r2 = await dmc.Raises.FindAsync(raise.Id);
            if (r2 == null)
                return false;
            dmc.Entry(r2).CurrentValues.SetValues(raise);
            await dmc.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteRaise(int id)
        {
            var raise = await GetRaiseById(id);
            if (raise == null)
                return false;
            dmc.Raises.Remove(raise);
            await dmc.SaveChangesAsync();
            return true;
        }
    }
}

