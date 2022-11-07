using ITBlog.Business.DTO;

namespace ITBlog.Presentation.Models
{
	public class CategoryModel
	{
		public List<PostDTO> Posts { get; set; }

		public CategoryDTO Category { get; set; }

		public List<CategoryDTO> Tags { get; set; }

		public PictureDTO CV { get; set; }

		public List<PostDTO> PopularPostOfCategory { get; set; }

		public List<PostDTO> RecentPostOfCategory { get; set; }
	}
}
