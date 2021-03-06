using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IVisitDL
    {
        Task<bool> DeleteDonorVisit(int id, int year);
        Task<List<DonorsVisit>> GetDonorsVisits();
        Task<List<DonorsVisit>> GetDonorsVisitsByYear(int year);
        
        Task<List<DonorsVisit>> GetDonorsVisitsByGroupId(int id);
        Task<DonorsVisit> GetDonorVisit(int id, int year);
        Task<List<DonorsVisit>> GetListOfVisitsByRaise(int id, int year);
        Task<List<DonorsVisit>> GetVisitsByGroup(int id);
        Task<List<RisingVisit>> GetRaisesVisits();
        Task<List<Status>> GetStatuses();
        Task<int> GetVisitsSumByGroup(int id);
        Task<bool> PostDonorVisit(DonorsVisit dv);
        Task<bool> PostRaiseVisit(RisingVisit rv);
        Task<bool> PutDonorVisit(int id, DonorsVisit dv);
        Task<bool> PutRaiseVisit(int id, RisingVisit rv);
    }
}