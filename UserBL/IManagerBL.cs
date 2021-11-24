using Entity;
using System.Threading.Tasks;

namespace BL
{
    public interface IManagerBL
    {
         Task<Manager> getManager(string ManagerName, string password);
         void putManager(string ManagerName, string password, string NewPassword);
    }
}