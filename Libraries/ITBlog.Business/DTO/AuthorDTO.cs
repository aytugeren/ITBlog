using ITBlog.Business.DTO.MappingDTOs;


namespace ITBlog.Business.DTO
{
    public class AuthorDTO : BaseDTO
    {
        public string? AuthorName { get; set; }

        public string? AuthorSecondName { get; set; }

        public string? AuthorLastName { get; set; }

        public DateTime AuthorBirthday { get; set; }

        public int PostCount { get; set; }

        public string AboutMe { get; set; }

        public string AuthorAim { get; set; }

        public int HoursPerWeek { get; set; }

        public int LinesOfCode { get; set; }

        public int CompletedProject { get; set; }

        public string? AuthorRole { get; set; }

        public virtual ICollection<PostDTO> Posts { get; set; }

        public virtual ICollection<AuthorPictureDTO> Pictures { get; set; }

        public virtual ICollection<SocialMediaDTO> SocialMedias { get; set; }

        public virtual ICollection<ProjectDTO> Projects { get; set; }

        public virtual ICollection<SkillDTO> Skills { get; set; }
    }
}
