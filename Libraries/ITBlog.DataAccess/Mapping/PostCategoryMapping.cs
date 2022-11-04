using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.PostCategoryFolder;
using ITBlog.Entities.Concrete.PostFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITBlog.DataAccess.Mapping
{
    public class PostCategoryMapping : IEntityTypeConfiguration<PostCategory>
    {
        public void Configure(EntityTypeBuilder<PostCategory> builder)
        {
            builder.HasKey(x => new { x.PostId, x.CategoryId });

            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.Property(x => x.CreatedDateTime).HasDefaultValue(DateTime.UtcNow);

            builder.ToTable("tblPostCategoryMapping");

            builder.HasOne<Post>(x => x.Post)
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.PostId);

            builder.HasOne<Category>(x => x.Category)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
