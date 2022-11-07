using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class postandcommentrelationshipsiscreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 626, DateTimeKind.Utc).AddTicks(1738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 177, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSubscriber",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 19, 34, 27, 625, DateTimeKind.Local).AddTicks(9441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 19, 25, 57, 177, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSocialMedia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 626, DateTimeKind.Utc).AddTicks(347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 177, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 624, DateTimeKind.Utc).AddTicks(9342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 176, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPictureMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 624, DateTimeKind.Utc).AddTicks(1482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 175, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostCategoryMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 624, DateTimeKind.Utc).AddTicks(5560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 175, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 623, DateTimeKind.Utc).AddTicks(3187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 174, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 623, DateTimeKind.Utc).AddTicks(9263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 175, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 623, DateTimeKind.Utc).AddTicks(8256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 175, DateTimeKind.Utc).AddTicks(2244));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "tblComment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 626, DateTimeKind.Utc).AddTicks(3676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 177, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.AlterColumn<string>(
                name: "CommentResult",
                table: "tblComment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "PostId",
                table: "tblComment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategoryPlaceMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 625, DateTimeKind.Utc).AddTicks(6962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 177, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 19, 34, 27, 623, DateTimeKind.Local).AddTicks(5213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 19, 25, 57, 174, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthorPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 625, DateTimeKind.Utc).AddTicks(2977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 176, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 623, DateTimeKind.Utc).AddTicks(6147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 175, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.CreateIndex(
                name: "IX_tblComment_PostId",
                table: "tblComment",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblComment_tblPost_PostId",
                table: "tblComment",
                column: "PostId",
                principalTable: "tblPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblComment_tblPost_PostId",
                table: "tblComment");

            migrationBuilder.DropIndex(
                name: "IX_tblComment_PostId",
                table: "tblComment");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "tblComment");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 177, DateTimeKind.Utc).AddTicks(4965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 626, DateTimeKind.Utc).AddTicks(1738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSubscriber",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 19, 25, 57, 177, DateTimeKind.Local).AddTicks(3035),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 19, 34, 27, 625, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblSocialMedia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 177, DateTimeKind.Utc).AddTicks(3878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 626, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 176, DateTimeKind.Utc).AddTicks(3692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 624, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPictureMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 175, DateTimeKind.Utc).AddTicks(5826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 624, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostCategoryMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 175, DateTimeKind.Utc).AddTicks(9796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 624, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 174, DateTimeKind.Utc).AddTicks(8775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 623, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 175, DateTimeKind.Utc).AddTicks(3372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 623, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 175, DateTimeKind.Utc).AddTicks(2244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 623, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "tblComment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 177, DateTimeKind.Utc).AddTicks(6540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 626, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.AlterColumn<string>(
                name: "CommentResult",
                table: "tblComment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategoryPlaceMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 177, DateTimeKind.Utc).AddTicks(459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 625, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 19, 25, 57, 174, DateTimeKind.Local).AddTicks(9582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 19, 34, 27, 623, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthorPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 176, DateTimeKind.Utc).AddTicks(7125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 625, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 7, 16, 25, 57, 175, DateTimeKind.Utc).AddTicks(540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 7, 16, 34, 27, 623, DateTimeKind.Utc).AddTicks(6147));
        }
    }
}
