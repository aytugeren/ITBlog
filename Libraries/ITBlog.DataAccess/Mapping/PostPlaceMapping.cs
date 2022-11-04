using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.PostPlaceFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITBlog.Entities.Concrete.PlaceFolder;

namespace ITBlog.DataAccess.Mapping
{
    public class PostPlaceMapping : IEntityTypeConfiguration<PostPlace>
    {
        public void Configure(EntityTypeBuilder<PostPlace> builder)
        {
            builder.HasKey(x => new { x.PostId, x.PlaceId });

            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            builder.Property(x => x.CreatedDateTime).HasDefaultValue(DateTime.UtcNow);

            builder.HasOne<Post>(x => x.Post)
                .WithMany(x => x.Places)
                .HasForeignKey(x => x.PostId);

            builder.HasOne<Place>(x => x.Place)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.PlaceId);
        }
    }
}
