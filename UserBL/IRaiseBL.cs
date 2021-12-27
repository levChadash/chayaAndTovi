using DTO;
using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using RaiseDTO = DTO.RaiseDTO;

namespace BL
{
    public interface IRaiseBL
    {
        Task<bool> DeleteRaise(int id);
        Task<List<RaiseDTO>> GetRaise();
        Task<RaiseDTO> GetRaise(string idNumber);
        Task<RaiseDTO> GetRaiseById(int id);
        Task<List<RaiseDTO>> GetRaise(string fn, string ln);
        Task<bool> PostRaise(RaiseDTO d);
        Task<bool> PutRaise(RaiseDTO raise);
    }
}