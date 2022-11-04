using ITBlog.Entities.Concrete.PlaceFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.DataAccess.Mapping
{
    public class PlaceMapping : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedDateTime).HasDefaultValue(DateTime.UtcNow);
            builder.ToTable("tblPlace");
        }
    }
}
