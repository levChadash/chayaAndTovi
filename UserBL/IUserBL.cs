using Entity;
using System.Threading.Tasks;

namespace BL
{
    public interface IUserBL
    {
         Task<ManagerName> getUser(string ManagerName, string password);
         Task<ManagerName> postUser(ManagerName m);
        void putUser(int id, ManagerName m);
    }
}