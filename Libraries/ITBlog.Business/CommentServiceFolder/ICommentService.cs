using ITBlog.Business.DTO;

namespace ITBlog.Business.CommentServiceFolder
{
	public interface ICommentService
	{
		List<CommentDTO> GetCommentsByPostId(Guid postId);

		bool InsertComment(CommentDTO commentDTO);
	}
}
