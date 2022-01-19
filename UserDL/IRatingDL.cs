using Entity;
using System.Threading.Tasks;

namespace DL
{
    public interface IRatingDL
    {
        Task<bool> PostRating(Rating r);
    }
}