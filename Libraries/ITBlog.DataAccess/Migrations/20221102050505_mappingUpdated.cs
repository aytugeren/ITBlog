using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class mappingUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 315, DateTimeKind.Utc).AddTicks(5623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 316, DateTimeKind.Utc).AddTicks(2193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 316, DateTimeKind.Utc).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 8, 5, 5, 315, DateTimeKind.Local).AddTicks(7279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 7, 0, 15, 761, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 315, DateTimeKind.Utc).AddTicks(8571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(6727));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(4401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 315, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(9744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 316, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(8474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 316, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 7, 0, 15, 761, DateTimeKind.Local).AddTicks(5594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 8, 5, 5, 315, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 4, 0, 15, 761, DateTimeKind.Utc).AddTicks(6727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 5, 5, 5, 315, DateTimeKind.Utc).AddTicks(8571));
        }
    }
}
