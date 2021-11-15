using Entity;
using System.Threading.Tasks;

namespace DL
{
    public interface IUserDL
    {
        async Task<user> getUser(string email, string password);
        async Task<user> postUser(user u);
        async Task<void>  putUser(int id, user u);
    }
}