

namespace ITBlog.Business.DTO.ViewDTOs
{
    public class PostListModel
    {
        public Guid Id { get; set; }

        public string? AuthorName { get; set; }

        public string? Title { get; set; }

        public string? ShortText { get; set; }

        public DateTime PublishDate { get; set; }

        public bool? IsActive { get; set; }
    }

    public class PostDetailPostModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string ShortText { get; set; }

        public string Content { get; set; }

        public string AuthorName { get; set; }
    }

}
