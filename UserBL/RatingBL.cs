﻿using DL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RatingBL : IRatingBL
    {

        IRatingDL rdl;
        public RatingBL(IRatingDL rdl)
        {
            this.rdl = rdl;
        }

        public async Task<bool> PostRating(Rating r)
        {

            return await rdl.PostRating(r);
        }
    }
}
