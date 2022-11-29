using ITBlog.Entities.Concrete.AuthorPictureFolder;
using ITBlog.Entities.Concrete.EntityFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.SocialMediaFolder;

namespace ITBlog.Entities.Concrete.AuthorFolder
{
    public class Author : BaseEntity
    {
        public Author()
        {
            this.Posts = new List<Post>();
            this.Pictures = new List<AuthorPicture>();
        }

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

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<AuthorPicture> Pictures { get; set; }

        public virtual ICollection<SocialMedia> SocialMedias { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }
    }
}
