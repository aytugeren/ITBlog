using ITBlog.Business.DTO.MappingDTOs;

namespace ITBlog.Business.DTO
{
    public class PostDTO : BaseDTO
    {
        public string? Title { get; set; }

        public string? FirstContent { get; set; }

        public string? SecondContent { get; set; }

        public Guid AuthorId { get; set; }

        public virtual ICollection<PostCategoryDTO> Categories { get; set; }

        public virtual ICollection<PostPictureDTO> Pictures { get; set; }

        public virtual AuthorDTO Author { get; set; }

        public virtual ICollection<PostPlaceDTO> Places { get; set; }

        public virtual ICollection<CommentDTO> Comments { get; set; }
    }
}
