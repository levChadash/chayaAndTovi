using Entity;
using System.Threading.Tasks;

namespace DL
{
    public interface IManagerDL
    {
        Task<Manager> getManager(string ManagerName, string password);

        void putManager(string ManagerName, string password, string NewPassword);
    }
}