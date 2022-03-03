using DTO;
using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IMassageBL
    {
        Task<bool> Delete();
        Task<bool> IsRead(int id);

        Task<bool> DeleteById(int id);
        Task<List<MassageDTO>> GetAllMassages();
        Task<List<MassageDTO>> GetMassagesByGroupId(int groupId);
        Task<MassageDTO> GetMassagesById(int id);
        Task<int> Post(MassageDTO massage);
        Task<int> PostText(string text);
    }
}