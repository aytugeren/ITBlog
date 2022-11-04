﻿using ITBlog.DataAccess.Mapping;
using ITBlog.Entities.Concrete;
using ITBlog.Entities.Concrete.AuthorFolder;
using ITBlog.Entities.Concrete.AuthorPictureFolder;
using ITBlog.Entities.Concrete.CategoryPlaceFolder;
using ITBlog.Entities.Concrete.PictureFolder;
using ITBlog.Entities.Concrete.PlaceFolder;
using ITBlog.Entities.Concrete.PostCategoryFolder;
using ITBlog.Entities.Concrete.PostFolder;
using ITBlog.Entities.Concrete.PostPictureFolder;
using ITBlog.Entities.Concrete.PostPlaceFolder;
using Microsoft.EntityFrameworkCore;

namespace ITBlog.DataAccess.ContextFolder
{
    public class ITBlogContext : DbContext
    {
        public ITBlogContext() 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TI3NI16\SQLEXPRESS;Database=ITBlog;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new AuthorMapping());
            modelBuilder.ApplyConfiguration(new PictureMapping());
            modelBuilder.ApplyConfiguration(new PlaceMapping());
            modelBuilder.ApplyConfiguration(new PostPictureMapping());
            modelBuilder.ApplyConfiguration(new PostCategoryMapping());
            modelBuilder.ApplyConfiguration(new PostPlaceMapping());
            modelBuilder.ApplyConfiguration(new AuthorPictureMapping());
            modelBuilder.ApplyConfiguration(new CategoryPlaceMapping());
        }

        public DbSet<Category> tblCategory { get; set; }

        public DbSet<Author> tblAuthor { get; set; }

        public DbSet<Post> tblPost { get; set; }

        public DbSet<Picture> tblPicture { get; set; }

        public DbSet<Place> tblPlace { get; set; }

        public DbSet<PostPicture> tblPostPicture { get; set; }

        public DbSet<PostCategory> tblPostCategory { get; set; }

        public DbSet<PostPlace> tblPostPlace { get; set; }

        public DbSet<AuthorPicture> tblAuthorPicture { get; set; }

        public DbSet<CategoryPlace> tblCategoryPlace { get; set; }
    }
}
