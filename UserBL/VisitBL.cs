using AutoMapper;
using DL;
using DTO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class VisitBL : IVisitBL
    {
        IVisitDL visitDL;
        IMapper mapper;
        public VisitBL(IVisitDL visitDL, IMapper mapper)
        {
            this.visitDL = visitDL;
            this.mapper = mapper;
        }

        public async Task<List<DonorsVisitDTO>> GetDonorsVisits()
        {
            List<DonorsVisit> ld = await visitDL.GetDonorsVisits();
            List<DonorsVisitDTO> ldDTO = mapper.Map<List<DonorsVisit>, List<DonorsVisitDTO>>(ld);
            return ldDTO;
        }

        public async Task<List<RisingVisitDTO>> GetRaisesVisits()
        {
            List<RisingVisit> lr = await visitDL.GetRaisesVisits();
            List<RisingVisitDTO> lrDTO = mapper.Map<List<RisingVisit>, List<RisingVisitDTO>>(lr);
            return lrDTO;
        }

        public async Task<List<DonorsVisitDTO>> GetVisitsByGroup(int id)
        {
            List<DonorsVisit> ld = await visitDL.GetVisitsByGroup(id);
            List<DonorsVisitDTO> ldDTO = mapper.Map<List<DonorsVisit>, List<DonorsVisitDTO>>(ld);
            return ldDTO;
        }
        public async Task<List<DonorsVisitDTO>> GetListOfVisitsByRaise(int id, int year)
        {
            List<DonorsVisit> ld = await visitDL.GetListOfVisitsByRaise(id, year);
            List<DonorsVisitDTO> ldDTO = mapper.Map<List<DonorsVisit>, List<DonorsVisitDTO>>(ld);
            return ldDTO;
        }


        public async Task<DonorsVisitDTO> GetDonorVisit(int id, int year)
        {
            DonorsVisit d = await visitDL.GetDonorVisit(id, year);
            DonorsVisitDTO dDTO = mapper.Map<DonorsVisit, DonorsVisitDTO>(d);
            return dDTO;
        }

        public async Task<List<DonorsVisitDTO>> GetDonorsVisitsByYear(int year)
        {
            List<DonorsVisit> ld = await visitDL.GetDonorsVisitsByYear(year);
            List<DonorsVisitDTO> ldDTO = mapper.Map<List<DonorsVisit>, List<DonorsVisitDTO>>(ld);
            return ldDTO;
        }
        
        public async Task<List<DonorsVisitDTO>> GetDonorsVisitsByGroupId(int id)
        {
            List<DonorsVisit> ld = await visitDL.GetDonorsVisitsByGroupId(id);
            List<DonorsVisitDTO> ldDTO = mapper.Map<List<DonorsVisit>, List<DonorsVisitDTO>>(ld);
            return ldDTO;
        }
        public async Task<bool> PostDonorVisit(DonorsVisitDTO dv)
        {
            DonorsVisit dd= mapper.Map< DonorsVisitDTO, DonorsVisit> (dv);
            return await visitDL.PostDonorVisit(dd);
        }

        public async Task<bool> PostRaiseVisit(RisingVisitDTO rv)
        {
            RisingVisit rr = mapper.Map<RisingVisitDTO, RisingVisit>(rv);
            return await visitDL.PostRaiseVisit(rr);
        }
        public async Task<bool> PutDonorVisit(int id, DonorsVisitDTO dv)
        {
            DonorsVisit dd = mapper.Map<DonorsVisitDTO, DonorsVisit>(dv);
            return await visitDL.PutDonorVisit(id, dd);
        }

        public async Task<bool> PutRaiseVisit(int id, RisingVisitDTO rv)
        {
            RisingVisit rr = mapper.Map<RisingVisitDTO, RisingVisit>(rv);
            return await visitDL.PutRaiseVisit(id, rr);
        }
        public async Task<bool> DeleteDonorVisit(int id, int year)
        {
            return await visitDL.DeleteDonorVisit(id, year);
        }


    }
}
