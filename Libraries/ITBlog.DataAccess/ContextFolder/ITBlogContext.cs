using ITBlog.DataAccess.Mapping;
using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.AuthorPictureFolder;
using ITBlog.Entities.Concrete.CategoryPlaceFolder;
using ITBlog.Entities.Concrete.CommentFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PlaceFolder;
using ITBlog.Entities.Concrete.PostCategoryFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.PostPictureFolder;
using ITBlog.Entities.Concrete.PostPlaceFolder;
using ITBlog.Entities.Concrete.SocialMediaFolder;
using ITBlog.Entities.Concrete.SubscriberFolder;
using ITBlog.Entities.Concrete.UserFolder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ITBlog.DataAccess.ContextFolder
{
    public class ITBlogContext : IdentityDbContext<IdentityUser>
    {
        public ITBlogContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=192.168.18.12;Database=ITBlog;User Id=sa;Password=DB258974!; Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PostMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new AuthorMapping());
            modelBuilder.ApplyConfiguration(new PictureMapping());
            modelBuilder.ApplyConfiguration(new PlaceMapping());
            modelBuilder.ApplyConfiguration(new PostPictureMapping());
            modelBuilder.ApplyConfiguration(new PostCategoryMapping());
            modelBuilder.ApplyConfiguration(new PostPlaceMapping());
            modelBuilder.ApplyConfiguration(new AuthorPictureMapping());
            modelBuilder.ApplyConfiguration(new CategoryPlaceMapping());
            modelBuilder.ApplyConfiguration(new SubscriberMapping());
            modelBuilder.ApplyConfiguration(new SocialMediaMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new CommentMapping());
            modelBuilder.ApplyConfiguration(new ProjectMapping());
            modelBuilder.ApplyConfiguration(new SkillMapping());
        }

        public DbSet<Category> tblCategory { get; set; }

        public DbSet<Author> tblAuthor { get; set; }

        public DbSet<Post> tblPost { get; set; }

        public DbSet<Picture> tblPicture { get; set; }

        public DbSet<Place> tblPlace { get; set; }

        public DbSet<PostPicture> tblPostPicture { get; set; }

        public DbSet<PostCategory> tblPostCategory { get; set; }

        public DbSet<PostPlace> tblPostPlace { get; set; }

        public DbSet<AuthorPicture> tblAuthorPicture { get; set; }

        public DbSet<CategoryPlace> tblCategoryPlace { get; set; }

        public DbSet<Subscriber> tblSubscriber { get; set; }

        public DbSet<SocialMedia> tblSocialMedia { get; set; }

        public DbSet<Comment> tblComment { get; set; }

        public DbSet<User> tblUser { get; set; }

        public DbSet<Project> tblProject { get; set; }

        public DbSet<Skill> tblSkill { get; set; }
    }
}
