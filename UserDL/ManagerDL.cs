using Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DL
{
    public class ManagerDL : IManagerDL
    {
        DonationManagementContext dmc;
        public async Task <Manager> GetManager(string managerName, string password)
        {
            Manager manager = await dmc.Managers.SingleOrDefaultAsync(m=>m.ManagerName== managerName&&m.password==password);
                    if (manager!=null)
                        return manager;
          return null;
        }
 
        public async void PutManager(string ManagerName, string password, string NewPassword)
        {
            Manager manager = await dmc.Managers.FindAsync(ManagerName);
            if (manager != null && manager.password == password)
            {
                 manager.password = NewPassword;
                 await dmc.SaveChangesAsync();
            }



        }
    }
}



