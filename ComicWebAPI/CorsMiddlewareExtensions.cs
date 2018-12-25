using Microsoft.AspNetCore.Builder;

namespace ComicWebAPI
{
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CorsMiddlewareExtensions
    {
        public static IApplicationBuilder UseCorsMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CorsMiddleware>();
        }
    }
}
