using Entity;
using System.Threading.Tasks;

namespace BL
{
    public interface IUserBL
    {
         Task<user> getUser(string ManagerName, string password);
         Task<user> postUser(user u);
        void putUser(int id, user u);
    }
}