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
    public class ErrorsMiddleWare
    {

        private readonly RequestDelegate _next;

        public ErrorsMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ILogger<Startup> logger)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ErrorsMiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorsMiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorsMiddleWare>();
        }
    }
}

