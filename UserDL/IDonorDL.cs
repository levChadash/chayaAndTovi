using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    interface IDonorDL
    {
        Task<List<Donor>> getDonors();
        Task<user> postUser(user u);
        void putUser(int id, user u);
    }
}