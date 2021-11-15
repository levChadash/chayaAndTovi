using Entity;

namespace DL
{
    public interface IUserDL
    {
        user getUser(string email, string password);
        user postUser(user u);
        void putUser(int id, user u);
    }
}