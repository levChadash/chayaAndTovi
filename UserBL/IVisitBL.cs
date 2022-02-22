using DTO;
using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IVisitBL
    {
        Task<bool> DeleteDonorVisit(int id, int year);
        Task<List<DonorsVisitDTO>> GetDonorsVisits();
        Task<List<DonorsVisitDTO>> GetDonorsVisitsByYear(int year);
        Task<List<DonorsVisitDTO>> GetDonorsVisitsByGroupId(int id);

        Task<DonorsVisitDTO> GetDonorVisit(int id, int year);
        Task<List<DonorsVisitDTO>> GetListOfVisitsByRaise(int id, int year);
        Task<List<RisingVisitDTO>> GetRaisesVisits();
        Task<List<DonorsVisitDTO>> GetVisitsByGroup(int id);
        Task<bool> PostDonorVisit(DonorsVisitDTO dv);
        Task<bool> PostRaiseVisit(RisingVisitDTO rv);
        Task<bool> PutDonorVisit(int id, DonorsVisitDTO dv);
        Task<bool> PutRaiseVisit(int id, RisingVisitDTO rv);
        
    }
}