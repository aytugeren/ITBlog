using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class placeTableAndRelationShipsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 369, DateTimeKind.Utc).AddTicks(8239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 429, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 430, DateTimeKind.Utc).AddTicks(2387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 6, 44, 13, 369, DateTimeKind.Local).AddTicks(9360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 14, 25, 25, 429, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 430, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.CreateTable(
                name: "tblPlace",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(3174)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPlace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPlace",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlacesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPlace", x => new { x.CategoriesId, x.PlacesId });
                    table.ForeignKey(
                        name: "FK_CategoryPlace_tblCategory_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "tblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPlace_tblPlace_PlacesId",
                        column: x => x.PlacesId,
                        principalTable: "tblPlace",
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
                name: "IX_CategoryPlace_PlacesId",
                table: "CategoryPlace",
                column: "PlacesId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacePost_PostsId",
                table: "PlacePost",
                column: "PostsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryPlace");

            migrationBuilder.DropTable(
                name: "PlacePost");

            migrationBuilder.DropTable(
                name: "tblPlace");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 429, DateTimeKind.Utc).AddTicks(8153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 369, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 430, DateTimeKind.Utc).AddTicks(2387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 14, 25, 25, 429, DateTimeKind.Local).AddTicks(9340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 6, 44, 13, 369, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 430, DateTimeKind.Utc).AddTicks(441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(438));
        }
    }
}
