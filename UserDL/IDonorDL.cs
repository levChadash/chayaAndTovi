using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IDonorDL
    {
        Task<List<Donor>> GetDonor(string fn, string ln);
        Task<List<Donor>> GetDonors();
        Task<bool> PostDonor(Donor d);
        Task<bool> PutDonor(int id, Donor d);
        Task<bool> DeleteDonor(Donor d);
    }
}