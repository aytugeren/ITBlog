using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class manytomanyrelationShipsReCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPlace_tblCategory_CategoriesId",
                table: "CategoryPlace");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPlace_tblPlace_PlacesId",
                table: "CategoryPlace");

            migrationBuilder.DropTable(
                name: "AuthorPicture");

            migrationBuilder.DropTable(
                name: "CategoryPost");

            migrationBuilder.DropTable(
                name: "PicturePost");

            migrationBuilder.DropTable(
                name: "PlacePost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryPlace",
                table: "CategoryPlace");

            migrationBuilder.RenameColumn(
                name: "PlacesId",
                table: "CategoryPlace",
                newName: "PlaceId");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "CategoryPlace",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryPlace_PlacesId",
                table: "CategoryPlace",
                newName: "IX_CategoryPlace_PlaceId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(3241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 315, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(8145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 316, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(7136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 316, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 16, 47, 16, 991, DateTimeKind.Local).AddTicks(4275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 8, 5, 5, 315, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(5165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 315, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "CategoryPlace",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "CategoryPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CategoryPlace",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CategoryPlace",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "CategoryPlace",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryPlace",
                table: "CategoryPlace",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tblAuthorPicture",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PictureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 993, DateTimeKind.Utc).AddTicks(9984)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuthorPicture", x => new { x.AuthorId, x.PictureId });
                    table.ForeignKey(
                        name: "FK_tblAuthorPicture_tblAuthor_Id",
                        column: x => x.Id,
                        principalTable: "tblAuthor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblAuthorPicture_tblPicture_Id",
                        column: x => x.Id,
                        principalTable: "tblPicture",
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
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 992, DateTimeKind.Utc).AddTicks(7094)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPostCategoryMapping", x => new { x.PostId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_tblPostCategoryMapping_tblCategory_Id",
                        column: x => x.Id,
                        principalTable: "tblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPostCategoryMapping_tblPost_Id",
                        column: x => x.Id,
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
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 992, DateTimeKind.Utc).AddTicks(435)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPostPictureMapping", x => new { x.PostId, x.PictureId });
                    table.ForeignKey(
                        name: "FK_tblPostPictureMapping_tblPicture_Id",
                        column: x => x.Id,
                        principalTable: "tblPicture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPostPictureMapping_tblPost_Id",
                        column: x => x.Id,
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
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 993, DateTimeKind.Utc).AddTicks(3778)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPostPlace", x => new { x.PostId, x.PlaceId });
                    table.ForeignKey(
                        name: "FK_tblPostPlace_tblPlace_Id",
                        column: x => x.Id,
                        principalTable: "tblPlace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPostPlace_tblPost_Id",
                        column: x => x.Id,
                        principalTable: "tblPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPlace_CategoryId",
                table: "CategoryPlace",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuthorPicture_Id",
                table: "tblAuthorPicture",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostCategoryMapping_Id",
                table: "tblPostCategoryMapping",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostPictureMapping_Id",
                table: "tblPostPictureMapping",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostPlace_Id",
                table: "tblPostPlace",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPlace_tblCategory_CategoryId",
                table: "CategoryPlace",
                column: "CategoryId",
                principalTable: "tblCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPlace_tblPlace_PlaceId",
                table: "CategoryPlace",
                column: "PlaceId",
                principalTable: "tblPlace",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPlace_tblCategory_CategoryId",
                table: "CategoryPlace");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPlace_tblPlace_PlaceId",
                table: "CategoryPlace");

            migrationBuilder.DropTable(
                name: "tblAuthorPicture");

            migrationBuilder.DropTable(
                name: "tblPostCategoryMapping");

            migrationBuilder.DropTable(
                name: "tblPostPictureMapping");

            migrationBuilder.DropTable(
                name: "tblPostPlace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryPlace",
                table: "CategoryPlace");

            migrationBuilder.DropIndex(
                name: "IX_CategoryPlace_CategoryId",
                table: "CategoryPlace");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CategoryPlace");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "CategoryPlace");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CategoryPlace");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CategoryPlace");

            migrationBuilder.DropColumn(
                name: "UpdatedDateTime",
                table: "CategoryPlace");

            migrationBuilder.RenameColumn(
                name: "PlaceId",
                table: "CategoryPlace",
                newName: "PlacesId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "CategoryPlace",
                newName: "CategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryPlace_PlaceId",
                table: "CategoryPlace",
                newName: "IX_CategoryPlace_PlacesId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 315, DateTimeKind.Utc).AddTicks(5623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 316, DateTimeKind.Utc).AddTicks(2193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 316, DateTimeKind.Utc).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 8, 5, 5, 315, DateTimeKind.Local).AddTicks(7279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 16, 47, 16, 991, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 315, DateTimeKind.Utc).AddTicks(8571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryPlace",
                table: "CategoryPlace",
                columns: new[] { "CategoriesId", "PlacesId" });

            migrationBuilder.CreateTable(
                name: "AuthorPicture",
                columns: table => new
                {
                    AuthorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PicturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorPicture", x => new { x.AuthorsId, x.PicturesId });
                    table.ForeignKey(
                        name: "FK_AuthorPicture_tblAuthor_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "tblAuthor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorPicture_tblPicture_PicturesId",
                        column: x => x.PicturesId,
                        principalTable: "tblPicture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPost",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPost", x => new { x.CategoriesId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_CategoryPost_tblCategory_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "tblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPost_tblPost_PostsId",
                        column: x => x.PostsId,
                        principalTable: "tblPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PicturePost",
                columns: table => new
                {
                    PicturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PicturePost", x => new { x.PicturesId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_PicturePost_tblPicture_PicturesId",
                        column: x => x.PicturesId,
                        principalTable: "tblPicture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PicturePost_tblPost_PostsId",
                        column: x => x.PostsId,
                        principalTable: "tblPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlacePost",
                columns: table => new
                {
                    PlacesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacePost", x => new { x.PlacesId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_PlacePost_tblPlace_PlacesId",
                        column: x => x.PlacesId,
                        principalTable: "tblPlace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlacePost_tblPost_PostsId",
                        column: x => x.PostsId,
                        principalTable: "tblPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPicture_PicturesId",
                table: "AuthorPicture",
                column: "PicturesId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPost_PostsId",
                table: "CategoryPost",
                column: "PostsId");

            migrationBuilder.CreateIndex(
                name: "IX_PicturePost_PostsId",
                table: "PicturePost",
                column: "PostsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacePost_PostsId",
                table: "PlacePost",
                column: "PostsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPlace_tblCategory_CategoriesId",
                table: "CategoryPlace",
                column: "CategoriesId",
                principalTable: "tblCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPlace_tblPlace_PlacesId",
                table: "CategoryPlace",
                column: "PlacesId",
                principalTable: "tblPlace",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
