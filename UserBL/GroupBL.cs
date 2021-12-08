using DL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class GroupBL : IGroupBL
    {
        IGroupDL gdl;
        public GroupBL(IGroupDL gdl)
        {
            this.gdl = gdl;
        }

        public async Task<Group> GetGroupByIdOfHead(int id)
        {
            return await gdl.GetGroupByIdOfHead(id);
        }

        public async Task<Group> GetGroupById(int id)
        {
            return await gdl.GetGroupById(id);
        }

        public async Task<Group> GetGroupByNum(int num)
        {
            return await gdl.GetGroupByNum(num);
        }

        public async Task<List<Group>> GetGroups()
        {
            return await gdl.GetGroups();
        }
        public async Task<bool> PostGroup(Group g)
        {
            return await gdl.PostGroup(g);
        }
        public async Task<bool> PutGroup(int id, Group g)
        {
            return await gdl.PutGroup(id, g);

        }

        public async Task<bool> DeleteGroup(int IdOfHead)
        {
            return await gdl.DeleteGroup(IdOfHead);
        }
    }
}

