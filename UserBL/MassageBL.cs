using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DL;
using DTO;
using Entity;

namespace BL
{
     public class MassageBL : IMassageBL
    {
        IMassageDL mdl;
        IMapper mapper;
        public MassageBL(IMassageDL mdl, IMapper mapper)
        {
            this.mdl = mdl;
            this.mapper = mapper;
        }
        public async Task<List<MassageDTO>> GetAllMassages()
        {
            List < Massage> lm= await mdl.GetAllMassages();
            List < MassageDTO > lmDTO= mapper.Map<List<Massage>, List<MassageDTO>>(lm);
            return lmDTO;
        }
        public async Task<List<MassageDTO>> GetMassagesByGroupId(int groupId )
        {
            List<Massage> lm = await mdl.GetMassagesByGroupId(groupId);
            List<MassageDTO> lmDTO = mapper.Map<List<Massage>, List<MassageDTO>>(lm);
            return lmDTO;
        }
        public async Task<MassageDTO> GetMassagesById(int id)
        {
            Massage m = await mdl.GetMassagesById(id);
            MassageDTO mDTO = mapper.Map<Massage, MassageDTO>(m);
            return mDTO;
        }
        public async Task<int> Post(MassageDTO massage)
        {

           Massage mm= mapper.Map<MassageDTO,Massage >(massage);
            mm.Time = DateTime.Now;
            return await mdl.Post(mm);
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
