using Entity;
using System.Threading.Tasks;

namespace BL
{
    public interface IDonorBL
    {
        Task<System.Collections.Generic.List<Donor>> GetDonor(string fn, string ln);
        Task<System.Collections.Generic.List<Donor>> GetDonors();
        Task<bool> PostDonor(Donor d);
        Task<bool> PutDonor(Donor d);
        Task<bool> DeleteDonor(Donor d);
    }
}