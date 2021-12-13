using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IMassageBL
    {
        Task<bool> Delete();
        Task<bool> DeleteById(int id);
        Task<List<Massage>> GetAllMassages();
        Task<List<Massage>> GetMassagesByGroupId(int groupId);
        Task<Massage> GetMassagesById(int id);
        Task<int> Post(Massage massage);
        Task<int> PostText(string text);
    }
}