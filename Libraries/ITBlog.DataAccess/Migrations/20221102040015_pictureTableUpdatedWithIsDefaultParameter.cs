using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class pictureTableUpdatedWithIsDefaultParameter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(4401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 369, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(9744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(8474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.AddColumn<bool>(
                name: "PictureIsDefault",
                table: "tblPicture",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 7, 0, 15, 761, DateTimeKind.Local).AddTicks(5594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 6, 44, 13, 369, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(6727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(438));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureIsDefault",
                table: "tblPicture");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 369, DateTimeKind.Utc).AddTicks(8239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(3174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(2137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 6, 44, 13, 369, DateTimeKind.Local).AddTicks(9360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 7, 0, 15, 761, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 3, 44, 13, 370, DateTimeKind.Utc).AddTicks(438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(6727));
        }
    }
}
