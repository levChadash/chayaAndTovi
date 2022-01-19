using Entity;
using System.Threading.Tasks;

namespace BL
{
    public interface IRatingBL
    {
        Task<bool> PostRating(Rating r);
    }
}