using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using Entity;

namespace BL
{
     public class MassageBL : IMassageBL
    {
        IMassageDL mdl;
        public MassageBL(IMassageDL mdl)
        {
            this.mdl = mdl;
        }
        public async Task<List<Massage>> GetAllMassages()
        {
            return await mdl.GetAllMassages();
        }
        public async Task<List<Massage>> GetMassagesByGroupId(int groupId )
        {
            return await mdl.GetMassagesByGroupId(groupId);
        }
        public async Task<Massage> GetMassagesById(int id)
        {
            return await mdl.GetMassagesById(id);
        }
        public async Task<int> Post(Massage massage)
        {
            return await mdl.Post(massage);
        }
        public async Task<int> PostText(string text)
        {
            return await mdl.PostText(text);
        }
        public async Task<bool> Delete()
        {
            return await mdl.Delete();
        }
        public async Task<bool> DeleteById(int id)
        {
            return await mdl.DeleteById(id);
        }
    }
}
