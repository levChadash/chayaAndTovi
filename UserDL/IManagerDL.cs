using Entity;
using System.Threading.Tasks;

namespace DL
{
    public interface IManagerDL
    {
        Task<Manager> GetManager(string managerName, string password);

        void PutManager(string managerName, string password, string newPassword);
    }
}