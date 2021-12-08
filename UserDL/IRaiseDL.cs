using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
   public interface IRaiseDL
    {
        Task<bool> DeleteRaise(int id);
        Task<List<Raise>> GetRaise();
        Task<Raise> GetRaiseById(int id);
        Task<Raise> GetRaise(string id);
        Task<List<Raise>> GetRaise(string fn, string ln);
        Task<bool> PostRaise(Raise raise);
        Task<bool> PutRaise(Raise raise);
    }
}