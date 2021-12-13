using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class MassageDL : IMassageDL
    {
        DonationManagementContext dmc;
        public MassageDL(DonationManagementContext dmc)
        {
            this.dmc = dmc;
        }
        public async Task<List<Massage>> GetAllMassages()
        {
            return await dmc.Massages.ToListAsync();
         
        }
        public async Task<List<Massage>> GetMassagesByGroupId(int groupId)
        {
            List < Massage > l = await dmc.Massages.Where(m => m.GroupId == groupId).ToListAsync();
            return l;
        }
        public async Task<Massage> GetMassagesById(int id)
        {
            return await dmc.Massages.FindAsync(id);
        }
        public async Task<int> Post(Massage massage )
        {
            await dmc.Massages.AddAsync(massage);
            await dmc.SaveChangesAsync();
            return massage.Id;
        }
        public async Task<int> PostText(string text)
        {
            Massage massage=new Massage();
            massage.Text = text;
            massage.GroupId = null;
            await dmc.Massages.AddAsync(massage);
            await dmc.SaveChangesAsync();
            return massage.Id;

        }
        public async Task<bool> Delete()
        {
            return false;
        }
        public async Task<bool> DeleteById(int id)
        {
            var massage = await GetMassagesById(id);
            if (massage == null)
                return false;
            dmc.Massages.Remove(massage);
            await dmc.SaveChangesAsync();
            return true;
        }
    }
}
