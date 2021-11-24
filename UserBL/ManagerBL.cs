using Entity;
using System;
using DL;
using System.Threading.Tasks;

namespace BL
{
    public class ManagerBL : IManagerBL
    {
        IManagerDL userdl ;
        public ManagerBL(ManagerDL Managerdl)
        {
            this.Managerdl = Managerdl;
        }
        public async Task<Manager> getManager(string ManagerName, string password)
        {

            return await Managerdl.getManager(ManagerName, password);
        }

        //public async Task<user> postUser(user u)
        //{
        //    return await userdl.postUser(u);
        //}
        public void putgetManager(string ManagerName, string password)
        {
            Managerdl.putManager(ManagerName, password);
        }
    }
}
