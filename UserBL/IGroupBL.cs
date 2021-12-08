using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IGroupBL
    {
        Task<bool> DeleteGroup(int id);
        Task<Group> GetGroupById(int id);
        Task<Group> GetGroupByIdOfHead(int id);
        Task<Group> GetGroupByNum(int num);
        Task<List<Raise>> GetListOfRaisesInGroup(int id);
        Task<List<Group>> GetGroups();
        Task<bool> PostGroup(Group g);
        Task<bool> PutGroup(int id, Group g);
    }
}