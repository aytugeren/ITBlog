using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class pictureTableColumnsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 429, DateTimeKind.Utc).AddTicks(8153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 189, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 430, DateTimeKind.Utc).AddTicks(2387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 190, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.AddColumn<string>(
                name: "PictureContent",
                table: "tblPicture",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureTitle",
                table: "tblPicture",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 14, 25, 25, 429, DateTimeKind.Local).AddTicks(9340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 16, 28, 189, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 430, DateTimeKind.Utc).AddTicks(441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 189, DateTimeKind.Utc).AddTicks(8212));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureContent",
                table: "tblPicture");

            migrationBuilder.DropColumn(
                name: "PictureTitle",
                table: "tblPicture");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 189, DateTimeKind.Utc).AddTicks(5370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 429, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 190, DateTimeKind.Utc).AddTicks(641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 430, DateTimeKind.Utc).AddTicks(2387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 16, 28, 189, DateTimeKind.Local).AddTicks(6885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 14, 25, 25, 429, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 10, 16, 28, 189, DateTimeKind.Utc).AddTicks(8212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 11, 25, 25, 430, DateTimeKind.Utc).AddTicks(441));
        }
    }
}
