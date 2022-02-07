using BL;
using Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MyFirstWebApiSite
{

    public class RatingMiddleWare
    {
        private readonly RequestDelegate _next;

        IRatingBL rbl;
        public RatingMiddleWare(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext httpContext, IRatingBL rbl)
        {
            this.rbl = rbl;
            Rating r = new Rating
            {
                Host = httpContext.Request.Host.ToString(),
                RecordDate = DateTime.Now,
                Method = httpContext.Request.Method,
                Path = httpContext.Request.Path.Value,
                Referer = httpContext.Request.Headers["Referrer"],
                UserAgent = httpContext.Request.Headers["User-Agent"].ToString()
            };
            await rbl.PostRating(r);
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RatingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRatingMiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RatingMiddleWare>();
        }
    }


}

