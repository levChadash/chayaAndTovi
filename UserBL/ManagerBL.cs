using Entity;
using DL;
using System.Threading.Tasks;

namespace BL
{
    public class ManagerBL : IManagerBL
    {
        IManagerDL managerdl;
        public ManagerBL(IManagerDL managerdl)
        {
            this.managerdl = managerdl;
        }
        public async Task<Manager> GetManager(string managerName, string password)
        {

            Manager m= await managerdl.GetManager(managerName, password);
            if (m!=null && m.Password == password)
                return m;
            return null;
        }
        public void PutManager(string managerName, string password, string newPassword)
        {
            managerdl.PutManager(managerName, password, newPassword);
        }
    }
}
