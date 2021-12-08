using Entity;
using System.Threading.Tasks;

namespace BL
{
    public interface IDonorBL
    {
        Task<System.Collections.Generic.List<Donor>> GetDonor(string fn, string ln);
        Task<Donor> GetDonorById(int id);
        Task<System.Collections.Generic.List<Donor>> GetDonors();
        Task<bool> PostDonor(Donor d);
        Task<bool> PutDonor(int id, Donor d);
        Task<bool> DeleteDonor(int id);
    }
}