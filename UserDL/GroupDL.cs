using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class GroupDL :IGroupDL
    {
        DonationManagementContext dmc;

        public GroupDL(DonationManagementContext dmc)
        {
            this.dmc = dmc;
        }

        public async Task<Group> GetGroupByIdOfHead(int id)
        {
            Group g = await dmc.Groups.Where(g => g.TeamHeadId == id).FirstOrDefaultAsync();
            return g;
        }

        public async Task<Group> GetGroupById(int id)
        {
            Group g = await dmc.Groups.FindAsync(id);
            return g;
        }

        public async Task<Group> GetGroupByNum(int num)
        {
            Group g = await dmc.Groups.Where(g => g.GroupNum == num).FirstOrDefaultAsync();
            return g;
        }


        public async Task<List<Group>> GetGroups()
        {
            List<Group> lg = await dmc.Groups.ToListAsync();
            return lg;
        }
        public async Task<bool> PostGroup(Group g)
        {
            await dmc.Groups.AddAsync(g);
            await dmc.SaveChangesAsync();
            return true;
        }
        public async Task<bool> PutGroup(int id, Group g)
        {
            var g2 = await dmc.Groups.FindAsync(id);
            if (g2 == null)
                return false;
            dmc.Entry(g2).CurrentValues.SetValues(g);
            await dmc.SaveChangesAsync();
            return true;

        }

        public async Task<bool> DeleteGroup(int IdOfHead)
        {
           var group= await GetGroupByIdOfHead(IdOfHead);
            if (group == null)
                return false;
           
            dmc.Groups.Remove(group);
            await dmc.SaveChangesAsync();
            return true; 
           
        }
    }
}
