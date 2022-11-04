using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.AuthorPictureFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PlaceFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITBlog.DataAccess.Mapping
{
    public class AuthorPictureMapping : IEntityTypeConfiguration<AuthorPicture>
    {
        public void Configure(EntityTypeBuilder<AuthorPicture> builder)
        {
            builder.HasKey(x => new { x.AuthorId, x.PictureId });

            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.Property(x => x.CreatedDateTime).HasDefaultValue(DateTime.UtcNow);

            builder.HasOne<Author>(x => x.Author)
                .WithMany(x => x.Pictures)
                .HasForeignKey(x => x.AuthorId);

            builder.HasOne<Picture>(x => x.Picture)
                .WithMany(x => x.Authors)
                .HasForeignKey(x => x.PictureId);
        }
    }
}
