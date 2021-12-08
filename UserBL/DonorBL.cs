using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL;
using System.Threading.Tasks;
using Entity;

namespace BL
{
    public class DonorBL : IDonorBL
    {
        IDonorDL ddl;
        public DonorBL(IDonorDL ddl)
        {
            this.ddl = ddl;
        }

        public async Task<List<Donor>> GetDonors() {
           return await ddl.GetDonors();
        }

        public async Task<Donor> GetDonorById(int id)
        {
            return await ddl.GetDonorById(id);
        }

        public async Task<List<Donor>> GetDonor(string fn, string ln)
        {
            return await ddl.GetDonor(fn, ln);
        }

        public async Task<bool> PostDonor( Donor d)
        {
            return await ddl.PostDonor(d);
        }

        public async Task<bool> PutDonor(int id, Donor d)
        {
            return await ddl.PutDonor(id,d);
        }

        public async Task<bool> DeleteDonor(int id)
        {
             return await ddl.DeleteDonor(id);
        }
    }
}
