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
            List<Massage> l = await dmc.Massages.Include(m=>m.Group).ToListAsync();
            return l;


        }
        public async Task<List<Massage>> GetMassagesByGroupId(int groupId)
        {
            List < Massage > l = await dmc.Massages.Where(m => m.GroupId == groupId|| m.GroupId == null).Include(m => m.Group).ToListAsync();
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
            massage.IsRead = false;
            await dmc.Massages.AddAsync(massage);
            await dmc.SaveChangesAsync();
            return massage.Id;

        }
        public async Task<bool> IsRead(int id)
        {
            var r2 = await dmc.Massages.FindAsync(id);
            if (r2 == null)
                return false;
            r2.IsRead = !r2.IsRead;
            await dmc.SaveChangesAsync();
            return true;
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
