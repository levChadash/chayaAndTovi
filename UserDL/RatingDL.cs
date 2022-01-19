using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    class RatingDL : IRatingDL
    {
        DonationManagementContext dmc;
        public RatingDL(DonationManagementContext dmc)
        {
            this.dmc = dmc;
        }

        public async Task<bool> PostRating(Rating r)
        {
            await dmc.Rating.AddAsync(r);
            await dmc.SaveChangesAsync();
            return true;
        }
    }
}
