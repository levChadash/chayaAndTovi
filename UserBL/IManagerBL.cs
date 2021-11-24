using Entity;
using System.Threading.Tasks;

namespace BL
{
    public interface IManagerBL
    {
         Task<Manager> getManager(string ManagerName, string password);
         //Task<Manager> postUser(ManagerName m);
        void putUser(string ManagerName, string password);
    }
}