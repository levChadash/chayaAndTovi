using Entity;
using System.Threading.Tasks;

namespace DL
{
    public interface IUserDL
    {
        Task<user> getUser(string email, string password);
        Task<user> postUser(user u);
        void putUser(int id, user u);
    }
}