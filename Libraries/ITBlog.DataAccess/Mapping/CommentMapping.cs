using ITBlog.Entities.Concrete.CommentFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.UserFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.DataAccess.Mapping
{
	public class CommentMapping : IEntityTypeConfiguration<Comment>
	{
		public void Configure(EntityTypeBuilder<Comment> builder)
		{
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedDateTime).HasDefaultValue(DateTime.UtcNow);

            builder.ToTable("tblComment");
            builder.HasOne<User>(x => x.User)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.UserId);

            builder.HasOne<Post>(x => x.Post)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.PostId);
        }
	}
}
