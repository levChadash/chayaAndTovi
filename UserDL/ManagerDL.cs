using Entity;
using System.Threading.Tasks;

namespace DL
{
    public class ManagerDL : IManagerDL
    {
        DonationManagementContext dmc;
        public async Task <Manager> getManager(string ManagerName, string password)
        {
            Manager manager = await dmc.Managers.FindAsync(ManagerName);
                    if (manager!=null && manager.password == password )
                        return manager;
          return null;
        }
 
        public async void putManager(string ManagerName, string password, string NewPassword)
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



