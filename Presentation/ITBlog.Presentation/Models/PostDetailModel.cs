using ITBlog.Business.DTO;

namespace ITBlog.Presentation.Models
{
	public class PostDetailModel
	{
		public PostDTO Post { get; set; }

		public string RelatedCategoryFlat { get; set; }

		public List<PostDTO> RecentPosts { get; set; }

		public List<PostDTO> RelatedPosts { get; set; }

		public List<CommentDTO> Comments { get; set; }

		public AuthorDTO Author { get; set; }
	}
}
