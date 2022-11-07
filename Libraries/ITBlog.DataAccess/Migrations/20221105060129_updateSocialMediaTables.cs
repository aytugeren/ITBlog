using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class updateSocialMediaTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSubscriber",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 9, 1, 29, 856, DateTimeKind.Local).AddTicks(8755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 8, 41, 13, 121, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSocialMedia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 856, DateTimeKind.Utc).AddTicks(9643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 121, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.AddColumn<string>(
                name: "SocialMediaButtonClass",
                table: "tblSocialMedia",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 855, DateTimeKind.Utc).AddTicks(9392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 120, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPictureMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 855, DateTimeKind.Utc).AddTicks(1996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 119, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostCategoryMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 855, DateTimeKind.Utc).AddTicks(5558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 120, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(4610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 118, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(9617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 119, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(8463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 119, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategoryPlaceMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 856, DateTimeKind.Utc).AddTicks(6331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 121, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 9, 1, 29, 854, DateTimeKind.Local).AddTicks(5687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 8, 41, 13, 118, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthorPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 856, DateTimeKind.Utc).AddTicks(2880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 120, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(6643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 119, DateTimeKind.Utc).AddTicks(412));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialMediaButtonClass",
                table: "tblSocialMedia");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSubscriber",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 8, 41, 13, 121, DateTimeKind.Local).AddTicks(4188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 9, 1, 29, 856, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSocialMedia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 121, DateTimeKind.Utc).AddTicks(5091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 856, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 120, DateTimeKind.Utc).AddTicks(4072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 855, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPictureMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 119, DateTimeKind.Utc).AddTicks(6229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 855, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostCategoryMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 120, DateTimeKind.Utc).AddTicks(134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 855, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 118, DateTimeKind.Utc).AddTicks(8426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 119, DateTimeKind.Utc).AddTicks(3618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 119, DateTimeKind.Utc).AddTicks(2395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategoryPlaceMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 121, DateTimeKind.Utc).AddTicks(1613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 856, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 8, 41, 13, 118, DateTimeKind.Local).AddTicks(9470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 9, 1, 29, 854, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthorPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 120, DateTimeKind.Utc).AddTicks(7699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 856, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 5, 41, 13, 119, DateTimeKind.Utc).AddTicks(412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 5, 6, 1, 29, 854, DateTimeKind.Utc).AddTicks(6643));
        }
    }
}
