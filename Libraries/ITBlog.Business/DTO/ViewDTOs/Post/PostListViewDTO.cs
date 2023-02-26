namespace ITBlog.Business.DTO.ViewDTOs
{
    public class PostListViewDTO
    {
        public Guid Id { get; set; }

        public string? AuthorName { get; set; }

        public string? Title { get; set; }

        public string? ShortText { get; set; }

        public string PublishDate { get; set; }

        public bool? IsActive { get; set; }

        public string MainPicture { get; set; }

        public int CommentCount { get; set; }

        public List<string> CategoryList { get; set; }

    }

}
