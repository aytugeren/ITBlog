namespace ITBlog.Business.DTO.ViewDTOs
{

    public class AddNewPostDTO : BaseDTO
    {

        public string Title { get; set; }

        public string ShortText { get; set; }

        public string Content { get; set; }

        public List<Guid> CategoryList { get; set; }


    }

}
