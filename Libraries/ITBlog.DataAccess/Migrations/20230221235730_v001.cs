using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class v001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(6764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 435, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSubscriber",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 2, 57, 30, 880, DateTimeKind.Local).AddTicks(6172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 21, 4, 17, 435, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSocialMedia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(6448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 435, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.AlterColumn<int>(
                name: "SkillLearntPercantage",
                table: "tblSkill",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSkill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(8069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 436, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblProject",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(7721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 435, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(2824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 434, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPictureMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 433, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostCategoryMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(1679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 434, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 879, DateTimeKind.Utc).AddTicks(7467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 432, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 879, DateTimeKind.Utc).AddTicks(9609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 433, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 879, DateTimeKind.Utc).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 433, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(7297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 435, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategoryPlaceMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(5362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 435, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 22, 2, 57, 30, 879, DateTimeKind.Local).AddTicks(8419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 21, 4, 17, 433, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthorPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(4250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 434, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 879, DateTimeKind.Utc).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 433, DateTimeKind.Utc).AddTicks(1411));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 435, DateTimeKind.Utc).AddTicks(6682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSubscriber",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 21, 4, 17, 435, DateTimeKind.Local).AddTicks(4797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 2, 57, 30, 880, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSocialMedia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 435, DateTimeKind.Utc).AddTicks(5729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.AlterColumn<int>(
                name: "SkillLearntPercantage",
                table: "tblSkill",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSkill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 436, DateTimeKind.Utc).AddTicks(1025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblProject",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 435, DateTimeKind.Utc).AddTicks(9903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 434, DateTimeKind.Utc).AddTicks(4774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPictureMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 433, DateTimeKind.Utc).AddTicks(6718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostCategoryMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 434, DateTimeKind.Utc).AddTicks(916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 432, DateTimeKind.Utc).AddTicks(8142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 879, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 433, DateTimeKind.Utc).AddTicks(4438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 879, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 433, DateTimeKind.Utc).AddTicks(3279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 879, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 435, DateTimeKind.Utc).AddTicks(8424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategoryPlaceMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 435, DateTimeKind.Utc).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 21, 4, 17, 433, DateTimeKind.Local).AddTicks(307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 22, 2, 57, 30, 879, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthorPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 434, DateTimeKind.Utc).AddTicks(8285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 880, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 23, 18, 4, 17, 433, DateTimeKind.Utc).AddTicks(1411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 21, 23, 57, 30, 879, DateTimeKind.Utc).AddTicks(8679));
        }
    }
}
