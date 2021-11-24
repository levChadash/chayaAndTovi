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
            List<Raise> ld = await dmc.Raises.Where(d => d.FirstName == fn && d.LastNme == ln).ToListAsync();
            return ld;
        }
        public async Task<Raise> GetRaise(string idNumber)
        {
            var raise = await dmc.Raises.SingleOrDefaultAsync(d => d.IdNumber == idNumber);
            return raise;
        }
        public async Task<bool> PostRaise(Raise raise)
        {
            await dmc.Raises.AddAsync(raise);
            return true;
        }
        public async Task<bool> PutRaise(Raise raise)
        {
            var d2 = await dmc.Raises.FindAsync(raise.IdNumber);
            d2 = raise;
            await dmc.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteRaise(string idNumber)
        {
            var raise = await GetRaise(idNumber);
            dmc.Remove(raise);
            await dmc.SaveChangesAsync();
            return true;

        }
    }
}

