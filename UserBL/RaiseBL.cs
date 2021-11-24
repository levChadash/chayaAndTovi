using DL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RaiseBL : IRaiseBL
    {
        IRaiseDL raiseDL;
        public RaiseBL(IRaiseDL raiseDL)
        {
            this.raiseDL = raiseDL;
        }

        public async Task<List<Raise>> GetRaise()
        {
            return await raiseDL.GetRaise();
        }

        public async Task<List<Raise>> GetRaise(string fn, string ln)
        {
            return await raiseDL.GetRaise(fn, ln);
        }
        public async Task<Raise> GetRaise(string idNumber)
        {
            return await raiseDL.GetRaise(idNumber);
        }
        public async Task<bool> PostRaise(Raise d)
        {
            return await raiseDL.PostRaise(d);
        }

        public async Task<bool> PutRaise(Raise raise)
        {
            return await raiseDL.PutRaise(raise);
        }

        public async Task<bool> DeleteRaise(string idNumber)
        {
            return await raiseDL.DeleteRaise(idNumber);
        }
    }
}

