using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.UserFolder;

namespace ITBlog.Entities.Concrete.CommentFolder
{
	public class Comment : BaseEntity
	{
		public string? CommentResult { get; set; }

		public string? Status { get; set; }

		public DateTime CommentDateTime { get; set; }

		public Guid UserId { get; set; }

		public Guid PostId { get; set; }

		public User User { get; set; }

		public Post Post { get; set; }
	}
}
