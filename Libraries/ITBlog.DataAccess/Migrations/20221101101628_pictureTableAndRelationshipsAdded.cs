using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class pictureTableAndRelationshipsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 189, DateTimeKind.Utc).AddTicks(5370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 4, 54, 40, 309, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 16, 28, 189, DateTimeKind.Local).AddTicks(6885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 7, 54, 40, 309, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 189, DateTimeKind.Utc).AddTicks(8212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 4, 54, 40, 309, DateTimeKind.Utc).AddTicks(8707));

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
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 190, DateTimeKind.Utc).AddTicks(641)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPicture", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPicture_PicturesId",
                table: "AuthorPicture",
                column: "PicturesId");

            migrationBuilder.CreateIndex(
                name: "IX_PicturePost_PostsId",
                table: "PicturePost",
                column: "PostsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorPicture");

            migrationBuilder.DropTable(
                name: "PicturePost");

            migrationBuilder.DropTable(
                name: "tblPicture");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 4, 54, 40, 309, DateTimeKind.Utc).AddTicks(6975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 189, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 7, 54, 40, 309, DateTimeKind.Local).AddTicks(7870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 16, 28, 189, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 4, 54, 40, 309, DateTimeKind.Utc).AddTicks(8707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 189, DateTimeKind.Utc).AddTicks(8212));
        }
    }
}
