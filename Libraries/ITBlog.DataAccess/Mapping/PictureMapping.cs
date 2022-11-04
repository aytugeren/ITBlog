using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PostFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.DataAccess.Mapping
{
    public class PictureMapping : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedDateTime).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.PictureIsDefault).HasDefaultValue(false);

            builder.ToTable("tblPicture");
        }
    }
}
