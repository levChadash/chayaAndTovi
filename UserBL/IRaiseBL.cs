using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IRaiseBL
    {
        Task<bool> DeleteRaise(string idNumber);
        Task<List<Raise>> GetRaise();
        Task<Raise> GetRaise(string idNumber);
        Task<List<Raise>> GetRaise(string fn, string ln);
        Task<bool> PostRaise(Raise d);
        Task<bool> PutRaise(Raise raise);
    }
}