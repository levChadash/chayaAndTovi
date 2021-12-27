using DTO;
using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IGroupBL
    {
        Task<bool> DeleteGroup(int id);
        Task<GroupDTO> GetGroupById(int id);
        Task<GroupDTO> GetGroupByIdOfHead(int id);
        Task<GroupDTO> GetGroupByNum(int num);
        Task<List<RaiseDTO>> GetListOfRaisesInGroup(int id);
        Task<List<GroupDTO>> GetGroups();
        Task<bool> PostGroup(GroupDTO g);
        Task<bool> PutGroup(int id, GroupDTO g);
    }
}