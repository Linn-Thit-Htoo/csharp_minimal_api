using csharp_minimal_api.Models;

namespace csharp_minimal_api.Services.BlogServices
{
    public class BlogService : IBlogService
    {
        public IEnumerable<BlogModel> GetAllBlogs()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return new BlogModel()
                {
                    BlogId = i,
                    BlogTitle = $"Blog Title {i}",
                    BlogAuthor = $"Blog Author {i}",
                    BlogContent = $"Blog Content {i}",
                    IsDeleted = false
                };
            }
        }
    }
}
