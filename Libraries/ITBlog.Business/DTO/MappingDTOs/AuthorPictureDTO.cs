namespace ITBlog.Business.DTO.MappingDTOs
{
    public class AuthorPictureDTO : BaseDTO
    {
        public Guid AuthorId { get; set; }

        public Guid PictureId { get; set; }

        public AuthorDTO Author { get; set; }

        public PictureDTO Picture { get; set; }
    }
}
