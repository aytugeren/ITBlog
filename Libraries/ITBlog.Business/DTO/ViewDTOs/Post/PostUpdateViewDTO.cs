namespace ITBlog.Business.DTO.ViewDTOs
{

    public class PostUpdateViewDTO
    {

        public string Title { get; set; }

        public string ShortText { get; set; }

        public string Content { get; set; }

        public List<Guid> CategoryList { get; set; }


    }

}
