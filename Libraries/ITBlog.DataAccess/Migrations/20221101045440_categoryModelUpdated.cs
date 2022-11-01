using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class categoryModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 4, 54, 40, 309, DateTimeKind.Utc).AddTicks(6975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 15, 20, 13, 368, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 7, 54, 40, 309, DateTimeKind.Local).AddTicks(7870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 18, 20, 13, 368, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.AddColumn<string>(
                name: "CategoryPlace",
                table: "tblCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategorySeoName",
                table: "tblCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryUrl",
                table: "tblCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 4, 54, 40, 309, DateTimeKind.Utc).AddTicks(8707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 15, 20, 13, 368, DateTimeKind.Utc).AddTicks(3280));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryPlace",
                table: "tblCategory");

            migrationBuilder.DropColumn(
                name: "CategorySeoName",
                table: "tblCategory");

            migrationBuilder.DropColumn(
                name: "CategoryUrl",
                table: "tblCategory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 15, 20, 13, 368, DateTimeKind.Utc).AddTicks(1179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 4, 54, 40, 309, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 18, 20, 13, 368, DateTimeKind.Local).AddTicks(2380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 7, 54, 40, 309, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 15, 20, 13, 368, DateTimeKind.Utc).AddTicks(3280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 4, 54, 40, 309, DateTimeKind.Utc).AddTicks(8707));
        }
    }
}
