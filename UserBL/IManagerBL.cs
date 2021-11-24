using Entity;
using System.Threading.Tasks;

namespace BL
{
    public interface IManagerBL
    {
         Task<Manager> GetManager(string managerName, string password);
         void PutManager(string managerName, string password, string newPassword);
    }
}