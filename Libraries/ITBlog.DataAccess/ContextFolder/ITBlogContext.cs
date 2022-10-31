using ITBlog.DataAccess.Mapping;
using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.PostFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.DataAccess.ContextFolder
{
    public class ITBlogContext : DbContext
    {
        public ITBlogContext() 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new AuthorMapping());

        }

        public DbSet<Category> tblCategory { get; set; }

        public DbSet<Author> tblAuthor { get; set; }

        public DbSet<Post> tblPost { get; set; }
    }
}
