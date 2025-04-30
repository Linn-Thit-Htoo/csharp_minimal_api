namespace csharp_minimal_api.Models
{
    public class BlogModel
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogAuthor { get; set; }
        public string BlogContent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
