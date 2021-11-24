using Entity;
using DL;
using System.Threading.Tasks;

namespace BL
{
    public class ManagerBL : IManagerBL
    {
        IManagerDL Managerdl;
        public ManagerBL(ManagerDL Managerdl)
        {
            this.Managerdl = Managerdl;
        }
        public async Task<Manager> getManager(string ManagerName, string password)
        {

            return await Managerdl.getManager(ManagerName, password);
        }
        public void putManager(string ManagerName, string password, string NewPassword)
        {
            Managerdl.putManager(ManagerName, password, NewPassword);
        }
    }
}
