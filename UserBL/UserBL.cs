using Entity;
using System;
using DL;
using System.Threading.Tasks;

namespace BL
{
    public class UserBL : IUserBL
    {
        IUserDL userdl ;
        public UserBL(IUserDL userdl)
        {
            this.userdl = userdl;
        }
        public async Task<Manager> getUser(string ManagerName, string password)
        {

            return await userdl.getUser(ManagerName, password);
        }

        public async Task<user> postUser(user u)
        {
            return await userdl.postUser(u);
        }
        public void putUser(int id, user u)
        {
            userdl.putUser(id, u);
        }
    }
}
