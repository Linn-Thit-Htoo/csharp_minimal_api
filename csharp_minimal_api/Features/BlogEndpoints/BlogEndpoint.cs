using csharp_minimal_api.Services.BlogServices;

namespace csharp_minimal_api.Features.BlogEndpoints
{
    public static class BlogEndpoint
    {
        public static void MapBlogEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/Blogs", async (IBlogService blogService) =>
            {
                var lst = blogService.GetAllBlogs();
                return Results.Ok(lst);
            }).WithName("GetBlogs").WithOpenApi();
        }
    }
}
