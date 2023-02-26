namespace ITBlog.Business.DTO.ViewDTOs
{

    public class PostDetailViewDTO : BaseDTO
    {

        public string Title { get; set; }

        public string ShortText { get; set; }

        public string Content { get; set; }

        public string AuthorName { get; set; }

        public List<PostCategoryViewDTO> PostCategories { get; set; }

        public List<string> PictureList { get; set; }

        public List<string> CommentList { get; set; }

    }

}
