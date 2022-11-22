using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.DataAccess.Mapping
{
    public class ProjectMapping : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedDateTime).HasDefaultValue(DateTime.UtcNow);

            builder.ToTable("tblProject");

            builder.HasMany<Author>(x => x.Authors)
                .WithMany(x => x.Projects);

            builder.HasMany<Picture>(x => x.Pictures)
                .WithMany(x => x.Projects);
        }
    }
}
