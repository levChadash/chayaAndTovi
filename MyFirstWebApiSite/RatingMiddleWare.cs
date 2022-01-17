using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApiSite
{
 
    public class RatingMiddleWare
    {
        private readonly RequestDelegate _next;
        public RatingMiddleWare(RequestDelegate next)
        {
            _next = next;
        }





    }
}
