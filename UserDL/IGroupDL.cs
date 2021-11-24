using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IGroupDL
    {
        Task<bool> DeleteGroup(Group g);
        Task<Group> GetGroupById(int id);
        Task<Group> GetGroupByIdOfHead(int id);
        Task<Group> GetGroupByNum(int num);
        Task<List<Group>> GetGroups();
        Task<bool> PostGroup(Group g);
        Task<bool> PutGroup(int id, Group g);
    }
}