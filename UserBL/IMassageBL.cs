using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    interface IMassageBL
    {
        Task<bool> Delete();
        Task<bool> DeleteById(int id);
        Task<List<Massage>> GetGroups();
        Task<List<Massage>> GetMassagesByGroupId(int groupId);
        Task<int> Post([FromBody] int id);
    }
}