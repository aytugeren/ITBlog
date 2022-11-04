using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.PostPictureFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITBlog.DataAccess.Mapping
{
    public class PostPictureMapping : IEntityTypeConfiguration<PostPicture>
    {
        public void Configure(EntityTypeBuilder<PostPicture> builder)
        {
            builder.HasKey(x => new { x.PostId, x.PictureId });

            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.Property(x => x.CreatedDateTime).HasDefaultValue(DateTime.UtcNow);

            builder.ToTable("tblPostPictureMapping");

            builder.HasOne<Post>(x => x.Post)
                .WithMany(x => x.Pictures)
                .HasForeignKey(x => x.PostId);

            builder.HasOne<Picture>(x => x.Picture)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.PictureId);
        }
    }
}
