using Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DL
{
    public class ManagerDL : IManagerDL
    {
        DonationManagementContext dmc;
        public ManagerDL(DonationManagementContext dmc)
        {
            this.dmc = dmc;
        }
        public async Task <Manager> GetManager(string managerName, string password)
        {
            return await dmc.Managers.SingleOrDefaultAsync(m=>m.ManagerName== managerName&&m.Password==password);
          
        }
 
        public async void PutManager(string managerName, string password, string newPassword)
        {
            var manager = await dmc.Managers.SingleOrDefaultAsync(m => m.ManagerName == managerName && m.Password == password); 
            if (manager != null )
            {    manager.Password = newPassword;
                 await dmc.SaveChangesAsync();
            }



        }
    }
}



