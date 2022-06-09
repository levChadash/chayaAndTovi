using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL;
using System.Threading.Tasks;
using Entity;
using AutoMapper;
using DTO;

namespace BL
{
    public class DonorBL : IDonorBL
    {
        IDonorDL ddl;
        IMapper mapper;
        public DonorBL(IDonorDL ddl, IMapper mapper)
        {
            this.ddl = ddl;
            this.mapper = mapper;
        }

        public async Task<List<DonorDTO>> GetDonors() {
            List<Donor> ld = await ddl.GetDonors();
            List<DonorDTO> ldDTO = mapper.Map<List<Donor>, List<DonorDTO>>(ld);
            for(int i=0;i< ldDTO.Count();i++)
            {
                ldDTO[i].ContactName= await ddl.getNameOfContact(ld[i].ContactId);
            }
            return ldDTO;
        }

        public async Task<DonorDTO> GetDonorById(int id)
        {
            Donor d= await ddl.GetDonorById(id);
            DonorDTO dDTO = mapper.Map<Donor, DonorDTO>(d);
          
            dDTO.ContactName =await  ddl.getNameOfContact(d.ContactId);
            return dDTO;
        }

        public async Task<List<DonorDTO>> GetDonor(string fn, string ln)
        {
            List<Donor> ld = await ddl.GetDonor(fn, ln);
            List<DonorDTO> ldDTO = mapper.Map<List<Donor>, List<DonorDTO>>(ld);
            return ldDTO;
        }

        public async Task<List<Contact>> GetContacts()
        {
            return await ddl.GetContacts();
        }

        public async Task<bool> PostDonor(DonorDTO d)
        {

            Donor dd = mapper.Map<DonorDTO, Donor>(d);
            dd.ContactId = await ddl.getIdOfContact(d.ContactName);
            return await ddl.PostDonor(dd);
        }

        public async Task<bool> PutDonor(int id, DonorDTO d)
        {
            Donor dd = mapper.Map<DonorDTO, Donor>(d);
            dd.ContactId = await ddl.getIdOfContact(d.ContactName);
            return await ddl.PutDonor(id, dd);
        }

        public async Task<bool> DeleteDonor(int id)
        {
             return await ddl.DeleteDonor(id);
        }
    }
}
