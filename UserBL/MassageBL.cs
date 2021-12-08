using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class MassageBL : IMassageBL
    {
        IMassageDL mdl;
        public MassageBL(IMassageBL mdl)
        {
            this.mdl = mdl;
        }
        public async Task<List<Massage>> GetGroups()
        {
            return await mdl.GetGroups();
        }
        public async Task<List<Massage>> GetMassagesByGroupId(int groupId)
        {
            return await mdl.GetMassagesByGroupId();
        }
        public async Task<int> Post( int id)
        {
            return await mdl.Post(id);
        }
        public async Task<bool> Delete()
        {
            return await mdl.Delete();
        }
        public async Task<bool> DeleteById(int id)
        {
            return await mdl.DeleteById();
        }
    }
}
