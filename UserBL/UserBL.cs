using Entity;
using System;
using DL;

namespace BL
{
    public class UserBL : IUserBL
    {
        IUserDL userdl ;
        public UserBL(IUserDL userdl)
        {
            this.userdl = userdl;
        }
        public user getUser(string email, string password)
        {

            return userdl.getUser(email, password);
        }

        public user postUser(user u)
        {
            return userdl.postUser(u);
        }
        public void putUser(int id, user u)
        {
            userdl.putUser(id, u);
        }
    }
}
