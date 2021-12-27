using AutoMapper;
using DL;
using DTO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaiseDTO = DTO.RaiseDTO;

namespace BL
{
    public class RaiseBL : IRaiseBL
    {
        IRaiseDL raiseDL;
        IMapper mapper;
        public RaiseBL(IRaiseDL raiseDL, IMapper mapper)
        {
            this.raiseDL = raiseDL;
            this.mapper = mapper;
        }

        public async Task<List<DTO.RaiseDTO>> GetRaise()
        {
            List<Raise> lr = await raiseDL.GetRaise();
            List<RaiseDTO> lrDTO = mapper.Map<List<Raise>, List<RaiseDTO>>(lr);
            return lrDTO;
        }

        public async Task<List<DTO.RaiseDTO>> GetRaise(string fn, string ln)
        {
            List<Raise> lr = await raiseDL.GetRaise(fn, ln);
            List<RaiseDTO> lrDTO = mapper.Map<List<Raise>, List<RaiseDTO>>(lr);
            return lrDTO;
        }

        public async Task<RaiseDTO> GetRaiseById(int id)
        {
            Raise r = await raiseDL.GetRaiseById(id);
            RaiseDTO rDTO = mapper.Map<Raise, RaiseDTO>(r);
            return rDTO;
        }
        public async Task<RaiseDTO> GetRaise(string idNumber)
        {
            Raise r = await raiseDL.GetRaise(idNumber);
            RaiseDTO rDTO = mapper.Map<Raise, RaiseDTO>(r);
            return rDTO;
        }
        public async Task<bool> PostRaise(RaiseDTO r)
        {
            Raise rr= mapper.Map<RaiseDTO, Raise>(r);
            return await raiseDL.PostRaise(rr);
        }

        public async Task<bool> PutRaise(RaiseDTO raise)
        {
            Raise rr = mapper.Map<RaiseDTO, Raise>(raise);
            return await raiseDL.PutRaise(rr);
        }

        public async Task<bool> DeleteRaise(int id)
        {
            return await raiseDL.DeleteRaise(id);
        }
    }
}

