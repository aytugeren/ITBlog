using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class projectIsCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAuthor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorSecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorBirthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostCount = table.Column<int>(type: "int", nullable: false),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorAim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoursPerWeek = table.Column<int>(type: "int", nullable: false),
                    LinesOfCode = table.Column<int>(type: "int", nullable: false),
                    CompletedProject = table.Column<int>(type: "int", nullable: false),
                    AuthorRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 578, DateTimeKind.Utc).AddTicks(3370)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuthor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCategoryMain = table.Column<bool>(type: "bit", nullable: false),
                    ParentCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategorySeoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 22, 15, 53, 578, DateTimeKind.Local).AddTicks(2459)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPicture",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PictureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    PicturePlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureAltName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureIsDefault = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 578, DateTimeKind.Utc).AddTicks(5202)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPicture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPlace",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 578, DateTimeKind.Utc).AddTicks(6209)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPlace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 585, DateTimeKind.Utc).AddTicks(2763)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProject_tblProject_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "tblProject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tblSocialMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocialMediaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaIconAsHtml = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaButtonClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 584, DateTimeKind.Utc).AddTicks(8353)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSocialMedia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblSubscriber",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriberEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActivedTheEmail = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 22, 15, 53, 584, DateTimeKind.Local).AddTicks(7255)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSubscriber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastVisitedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 584, DateTimeKind.Utc).AddTicks(9349)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPost",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 578, DateTimeKind.Utc).AddTicks(310)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPost_tblAuthor_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "tblAuthor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuthorPicture",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PictureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 584, DateTimeKind.Utc).AddTicks(517)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuthorPicture", x => new { x.AuthorId, x.PictureId });
                    table.ForeignKey(
                        name: "FK_tblAuthorPicture_tblAuthor_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "tblAuthor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblAuthorPicture_tblPicture_PictureId",
                        column: x => x.PictureId,
                        principalTable: "tblPicture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCategoryPlaceMapping",
                columns: table => new
                {
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 584, DateTimeKind.Utc).AddTicks(4288)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategoryPlaceMapping", x => new { x.CategoryId, x.PlaceId });
                    table.ForeignKey(
                        name: "FK_tblCategoryPlaceMapping_tblCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "tblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCategoryPlaceMapping_tblPlace_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "tblPlace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorProject",
                columns: table => new
                {
                    AuthorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorProject", x => new { x.AuthorsId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_AuthorProject_tblAuthor_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "tblAuthor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorProject_tblProject_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "tblProject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PictureProject",
                columns: table => new
                {
                    PicturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureProject", x => new { x.PicturesId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_PictureProject_tblPicture_PicturesId",
                        column: x => x.PicturesId,
                        principalTable: "tblPicture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PictureProject_tblProject_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "tblProject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorSocialMedia",
                columns: table => new
                {
                    AuthorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocialMediasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorSocialMedia", x => new { x.AuthorsId, x.SocialMediasId });
                    table.ForeignKey(
                        name: "FK_AuthorSocialMedia_tblAuthor_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "tblAuthor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorSocialMedia_tblSocialMedia_SocialMediasId",
                        column: x => x.SocialMediasId,
                        principalTable: "tblSocialMedia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 585, DateTimeKind.Utc).AddTicks(1146)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblComment_tblPost_PostId",
                        column: x => x.PostId,
                        principalTable: "tblPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblComment_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPostCategoryMapping",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 583, DateTimeKind.Utc).AddTicks(3069)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPostCategoryMapping", x => new { x.PostId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_tblPostCategoryMapping_tblCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "tblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPostCategoryMapping_tblPost_PostId",
                        column: x => x.PostId,
                        principalTable: "tblPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPostPictureMapping",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PictureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 578, DateTimeKind.Utc).AddTicks(8556)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPostPictureMapping", x => new { x.PostId, x.PictureId });
                    table.ForeignKey(
                        name: "FK_tblPostPictureMapping_tblPicture_PictureId",
                        column: x => x.PictureId,
                        principalTable: "tblPicture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPostPictureMapping_tblPost_PostId",
                        column: x => x.PostId,
                        principalTable: "tblPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPostPlace",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 22, 19, 15, 53, 583, DateTimeKind.Utc).AddTicks(6945)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPostPlace", x => new { x.PostId, x.PlaceId });
                    table.ForeignKey(
                        name: "FK_tblPostPlace_tblPlace_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "tblPlace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPostPlace_tblPost_PostId",
                        column: x => x.PostId,
                        principalTable: "tblPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorProject_ProjectsId",
                table: "AuthorProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorSocialMedia_SocialMediasId",
                table: "AuthorSocialMedia",
                column: "SocialMediasId");

            migrationBuilder.CreateIndex(
                name: "IX_PictureProject_ProjectsId",
                table: "PictureProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuthorPicture_PictureId",
                table: "tblAuthorPicture",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCategoryPlaceMapping_PlaceId",
                table: "tblCategoryPlaceMapping",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_tblComment_PostId",
                table: "tblComment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_tblComment_UserId",
                table: "tblComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPost_AuthorId",
                table: "tblPost",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostCategoryMapping_CategoryId",
                table: "tblPostCategoryMapping",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostPictureMapping_PictureId",
                table: "tblPostPictureMapping",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostPlace_PlaceId",
                table: "tblPostPlace",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProject_ProjectId",
                table: "tblProject",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorProject");

            migrationBuilder.DropTable(
                name: "AuthorSocialMedia");

            migrationBuilder.DropTable(
                name: "PictureProject");

            migrationBuilder.DropTable(
                name: "tblAuthorPicture");

            migrationBuilder.DropTable(
                name: "tblCategoryPlaceMapping");

            migrationBuilder.DropTable(
                name: "tblComment");

            migrationBuilder.DropTable(
                name: "tblPostCategoryMapping");

            migrationBuilder.DropTable(
                name: "tblPostPictureMapping");

            migrationBuilder.DropTable(
                name: "tblPostPlace");

            migrationBuilder.DropTable(
                name: "tblSubscriber");

            migrationBuilder.DropTable(
                name: "tblSocialMedia");

            migrationBuilder.DropTable(
                name: "tblProject");

            migrationBuilder.DropTable(
                name: "tblUser");

            migrationBuilder.DropTable(
                name: "tblCategory");

            migrationBuilder.DropTable(
                name: "tblPicture");

            migrationBuilder.DropTable(
                name: "tblPlace");

            migrationBuilder.DropTable(
                name: "tblPost");

            migrationBuilder.DropTable(
                name: "tblAuthor");
        }
    }
}
