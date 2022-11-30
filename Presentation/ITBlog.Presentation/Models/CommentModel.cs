namespace ITBlog.Presentation.Models
{
    public class CommentModel
    {
        public string? Comment { get; set; }

        public Guid PostId { get; set; }
    }
}
