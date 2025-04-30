using csharp_minimal_api.Models;

namespace csharp_minimal_api.Services.BlogServices
{
    public interface IBlogService
    {
        IEnumerable<BlogModel> GetAllBlogs();
    }
}
