using ITBlog.Business.DTO.MappingDTOs;

namespace ITBlog.Business.DTO
{
    public class PictureDTO : BaseDTO
    {
        public string? PictureName { get; set; }

        public string? PictureUrl { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public string? PicturePlace { get; set; }

        public string? PictureAltName { get; set; }

        public string? PictureFilePath { get; set; }

        public string? PictureExtension { get; set; }

        public string? PictureTitle { get; set; }

        public string? PictureContent { get; set; }
        public bool PictureIsDefault { get; set; }

        public virtual ICollection<PostPictureDTO> Posts { get; set; }

        public virtual ICollection<AuthorPictureDTO> Authors { get; set; }
    }
}
