using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IDonorDL
    {
        Task<List<Donor>> GetDonor(string fn, string ln);
        Task<Donor> GetDonorById(int id);
        Task<List<Donor>> GetDonors();
        Task<List<Contact>> GetContacts();
        Task<bool> PostDonor(Donor d);
        Task<bool> PutDonor(int id, Donor d);
        Task<bool> DeleteDonor(int id);
    }
}