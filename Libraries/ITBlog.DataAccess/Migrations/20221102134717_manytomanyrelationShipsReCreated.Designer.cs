﻿// <auto-generated />
using System;
using ITBlog.DataAccess.ContextFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    [DbContext(typeof(ITBlogContext))]
    [Migration("20221102134717_manytomanyrelationShipsReCreated")]
    partial class manytomanyrelationShipsReCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ITBlog.Entities.Concrete.AuthorFolder.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AuthorBirthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("AuthorLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorSecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(5165));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("PostCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tblAuthor", (string)null);
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.AuthorPictureFolder.AuthorPicture", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PictureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 2, 13, 47, 16, 993, DateTimeKind.Utc).AddTicks(9984));

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("AuthorId", "PictureId");

                    b.HasIndex("Id");

                    b.ToTable("tblAuthorPicture");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategorySeoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 2, 16, 47, 16, 991, DateTimeKind.Local).AddTicks(4275));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsCategoryMain")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<Guid?>("ParentCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tblCategory", (string)null);
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.CategoryPlaceFolder.CategoryPlace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("PlaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PlaceId");

                    b.ToTable("CategoryPlace");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PictureFolder.Picture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(7136));

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PictureAltName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PictureIsDefault")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PictureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicturePlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tblPicture", (string)null);
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PlaceFolder.Place", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(8145));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tblPlace", (string)null);
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PostCategoryFolder.PostCategory", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 2, 13, 47, 16, 992, DateTimeKind.Utc).AddTicks(7094));

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PostId", "CategoryId");

                    b.HasIndex("Id");

                    b.ToTable("tblPostCategoryMapping", (string)null);
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PostFolder.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(3241));

                    b.Property<string>("FirstContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("SecondContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("tblPost", (string)null);
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PostPictureFolder.PostPicture", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PictureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 2, 13, 47, 16, 992, DateTimeKind.Utc).AddTicks(435));

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PostId", "PictureId");

                    b.HasIndex("Id");

                    b.ToTable("tblPostPictureMapping", (string)null);
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PostPlaceFolder.PostPlace", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 2, 13, 47, 16, 993, DateTimeKind.Utc).AddTicks(3778));

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PostId", "PlaceId");

                    b.HasIndex("Id");

                    b.ToTable("tblPostPlace");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.AuthorPictureFolder.AuthorPicture", b =>
                {
                    b.HasOne("ITBlog.Entities.Concrete.AuthorFolder.Author", "Author")
                        .WithMany("Pictures")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITBlog.Entities.Concrete.PictureFolder.Picture", "Picture")
                        .WithMany("Authors")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.CategoryPlaceFolder.CategoryPlace", b =>
                {
                    b.HasOne("ITBlog.Entities.Concrete.Category", "Category")
                        .WithMany("Places")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITBlog.Entities.Concrete.PlaceFolder.Place", "Place")
                        .WithMany("Categories")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Place");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PostCategoryFolder.PostCategory", b =>
                {
                    b.HasOne("ITBlog.Entities.Concrete.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITBlog.Entities.Concrete.PostFolder.Post", "Post")
                        .WithMany("Categories")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PostFolder.Post", b =>
                {
                    b.HasOne("ITBlog.Entities.Concrete.AuthorFolder.Author", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PostPictureFolder.PostPicture", b =>
                {
                    b.HasOne("ITBlog.Entities.Concrete.PictureFolder.Picture", "Picture")
                        .WithMany("Posts")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITBlog.Entities.Concrete.PostFolder.Post", "Post")
                        .WithMany("Pictures")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Picture");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PostPlaceFolder.PostPlace", b =>
                {
                    b.HasOne("ITBlog.Entities.Concrete.PlaceFolder.Place", "Place")
                        .WithMany("Posts")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITBlog.Entities.Concrete.PostFolder.Post", "Post")
                        .WithMany("Places")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.AuthorFolder.Author", b =>
                {
                    b.Navigation("Pictures");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Places");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PictureFolder.Picture", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PlaceFolder.Place", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PostFolder.Post", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Pictures");

                    b.Navigation("Places");
                });
#pragma warning restore 612, 618
        }
    }
}