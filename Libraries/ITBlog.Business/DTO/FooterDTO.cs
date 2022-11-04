namespace ITBlog.Business.DTO
{
	public class FooterDTO
	{
		public List<CategoryDTO> Categories { get; set; }

		public PictureDTO FooterLogo { get; set; }

		public List<PostDTO> Posts { get; set; }
	}
}
