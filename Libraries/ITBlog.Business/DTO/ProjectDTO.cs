namespace ITBlog.Business.DTO
{
    public class ProjectDTO : BaseDTO
    {
        public string? ProjectName { get; set; }

        public string? ProjectDescription { get; set; }

        public string? ProjectLink { get; set; }

        public virtual ICollection<AuthorDTO> Authors { get; set; }

        public virtual ICollection<PictureDTO> Pictures { get; set; }

        public virtual ICollection<ProjectDTO> Projects { get; set; }
    }
}
