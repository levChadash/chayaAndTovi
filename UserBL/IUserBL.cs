using Entity;

namespace BL
{
    public interface IUserBL
    {
        user getUser(string email, string password);
        user postUser(user u);
        void putUser(int id, user u);
    }
}