using DTO;
using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IDonorBL
    {
        Task<System.Collections.Generic.List<DonorDTO>> GetDonor(string fn, string ln);
        Task<DonorDTO> GetDonorById(int id);
        Task<List<DonorDTO>> GetDonors();
        Task<List<Contact>> GetContacts();
        Task<bool> PostDonor(DonorDTO d);
        Task<bool> PutDonor(int id, DonorDTO d);
        Task<bool> DeleteDonor(int id);
    }
}