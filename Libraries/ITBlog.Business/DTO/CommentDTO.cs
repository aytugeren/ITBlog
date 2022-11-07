namespace ITBlog.Business.DTO
{
	public class CommentDTO : BaseDTO
	{
        public string? CommentResult { get; set; }

        public string? Status { get; set; }

        public DateTime CommentDateTime { get; set; }

        public Guid UserId { get; set; }

        public Guid PostId { get; set; }

        public UserDTO User { get; set; }

        public PostDTO Post { get; set; }
    }
}
