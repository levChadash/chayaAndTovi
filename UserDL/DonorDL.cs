using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DL
{
    public class DonorDL : IDonorDL
    {
        
        DonationManagementContext dmc;
        public DonorDL(DonationManagementContext dmc)
        {
            this.dmc = dmc;
        }
        public async Task<List<Donor>> GetDonors()
        {
            List<Donor> ld = await dmc.Donors.ToListAsync();
            return ld;
        }

        public async Task<List<Donor>> GetDonor(string fn, string ln)
        {
            List<Donor> ld = await dmc.Donors.Where(d => d.FirstName == fn && d.LastNme == ln).ToListAsync();
            return ld;
        }
        public async Task<bool> PostDonor(Donor d)
        {
            await dmc.Donors.AddAsync(d);
            return true;
        }
        public async Task<bool> PutDonor(Donor d)
        {
            var d2 = await dmc.Donors.FindAsync(d.Id);
            d2 = d;
            await dmc.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteDonor(Donor d)
        {
            dmc.Remove(d);
            dmc.SaveChanges();
            return true;

        }
    }
}
