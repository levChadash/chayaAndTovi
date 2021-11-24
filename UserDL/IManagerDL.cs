using Entity;
using System.Threading.Tasks;

namespace DL
{
    public interface IManagerDL
    {
        Task<Manager> getManager(string name, string password);
        //Task<user> postUser(user u);
        void putManager(string name, string password);
    }
}