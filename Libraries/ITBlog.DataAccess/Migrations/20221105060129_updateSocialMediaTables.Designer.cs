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
    [Migration("20221105060129_updateSocialMediaTables")]
    partial class updateSocialMediaTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorSocialMedia", b =>
                {
                    b.Property<Guid>("AuthorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SocialMediasId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AuthorsId", "SocialMediasId");

                    b.HasIndex("SocialMediasId");

                    b.ToTable("AuthorSocialMedia");
                });

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
                        .HasDefaultValue(new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(6643));

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
                        .HasDefaultValue(new DateTime(2022, 11, 5, 6, 1, 29, 856, DateTimeKind.Utc).AddTicks(2880));

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

                    b.HasIndex("PictureId");

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
                        .HasDefaultValue(new DateTime(2022, 11, 5, 9, 1, 29, 854, DateTimeKind.Local).AddTicks(5687));

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
                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 5, 6, 1, 29, 856, DateTimeKind.Utc).AddTicks(6331));

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

                    b.HasKey("CategoryId", "PlaceId");

                    b.HasIndex("PlaceId");

                    b.ToTable("tblCategoryPlaceMapping", (string)null);
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PictureFolder.Picture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(8463));

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
                        .HasDefaultValue(new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(9617));

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
                        .HasDefaultValue(new DateTime(2022, 11, 5, 6, 1, 29, 855, DateTimeKind.Utc).AddTicks(5558));

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

                    b.HasIndex("CategoryId");

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
                        .HasDefaultValue(new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(4610));

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
                        .HasDefaultValue(new DateTime(2022, 11, 5, 6, 1, 29, 855, DateTimeKind.Utc).AddTicks(1996));

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

                    b.HasIndex("PictureId");

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
                        .HasDefaultValue(new DateTime(2022, 11, 5, 6, 1, 29, 855, DateTimeKind.Utc).AddTicks(9392));

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

                    b.HasIndex("PlaceId");

                    b.ToTable("tblPostPlace");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.SocialMediaFolder.SocialMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 5, 6, 1, 29, 856, DateTimeKind.Utc).AddTicks(9643));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("SocialMediaButtonClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMediaIconAsHtml")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMediaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMediaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tblSocialMedia", (string)null);
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.SubscriberFolder.Subscriber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 5, 9, 1, 29, 856, DateTimeKind.Local).AddTicks(8755));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsActivedTheEmail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("SubscriberEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tblSubscriber", (string)null);
                });

            modelBuilder.Entity("AuthorSocialMedia", b =>
                {
                    b.HasOne("ITBlog.Entities.Concrete.AuthorFolder.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITBlog.Entities.Concrete.SocialMediaFolder.SocialMedia", null)
                        .WithMany()
                        .HasForeignKey("SocialMediasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.AuthorPictureFolder.AuthorPicture", b =>
                {
                    b.HasOne("ITBlog.Entities.Concrete.AuthorFolder.Author", "Author")
                        .WithMany("Pictures")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITBlog.Entities.Concrete.PictureFolder.Picture", "Picture")
                        .WithMany("Authors")
                        .HasForeignKey("PictureId")
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
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITBlog.Entities.Concrete.PostFolder.Post", "Post")
                        .WithMany("Categories")
                        .HasForeignKey("PostId")
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
                        .HasForeignKey("PictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITBlog.Entities.Concrete.PostFolder.Post", "Post")
                        .WithMany("Pictures")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Picture");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("ITBlog.Entities.Concrete.PostPlaceFolder.PostPlace", b =>
                {
                    b.HasOne("ITBlog.Entities.Concrete.PlaceFolder.Place", "Place")
                        .WithMany("Posts")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITBlog.Entities.Concrete.PostFolder.Post", "Post")
                        .WithMany("Places")
                        .HasForeignKey("PostId")
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