namespace ITBlog.Presentation.Models
{
    public class CommentModel
    {

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Comment { get; set; }

        public Guid PostId { get; set; }
    }
}
