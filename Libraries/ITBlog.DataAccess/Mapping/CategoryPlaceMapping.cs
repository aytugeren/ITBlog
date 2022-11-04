using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.CategoryPlaceFolder;
using ITBlog.Entities.Concrete.PlaceFolder;
using ITBlog.Entities.Concrete.PostFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITBlog.DataAccess.Mapping
{
    public class CategoryPlaceMapping : IEntityTypeConfiguration<CategoryPlace>
    {
        public void Configure(EntityTypeBuilder<CategoryPlace> builder)
        {
            builder.HasKey(x => new { x.CategoryId, x.PlaceId });

            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.Property(x => x.CreatedDateTime).HasDefaultValue(DateTime.UtcNow);

            builder.ToTable("tblCategoryPlaceMapping");

            builder.HasOne<Category>(x => x.Category)
                .WithMany(x => x.Places)
                .HasForeignKey(x => x.CategoryId);

            builder.HasOne<Place>(x => x.Place)
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.PlaceId);
        }
    }
}
