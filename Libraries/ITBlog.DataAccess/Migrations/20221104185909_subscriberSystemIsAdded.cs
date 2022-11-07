using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class subscriberSystemIsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 44, DateTimeKind.Utc).AddTicks(3540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPictureMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 43, DateTimeKind.Utc).AddTicks(6071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostCategoryMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 44, DateTimeKind.Utc).AddTicks(69),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 42, DateTimeKind.Utc).AddTicks(8994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 532, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 43, DateTimeKind.Utc).AddTicks(3940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 43, DateTimeKind.Utc).AddTicks(2613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategoryPlaceMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 45, DateTimeKind.Utc).AddTicks(596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 21, 59, 9, 42, DateTimeKind.Local).AddTicks(9898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 16, 55, 54, 532, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthorPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 44, DateTimeKind.Utc).AddTicks(7058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 43, DateTimeKind.Utc).AddTicks(801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 532, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.CreateTable(
                name: "tblSubscriber",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriberEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActivedTheEmail = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 4, 21, 59, 9, 45, DateTimeKind.Local).AddTicks(3076)),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSubscriber", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblSubscriber");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(1011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 44, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPictureMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(3391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 43, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostCategoryMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(7170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 44, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 532, DateTimeKind.Utc).AddTicks(6695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 42, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(1196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 43, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 43, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategoryPlaceMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(8270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 45, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 16, 55, 54, 532, DateTimeKind.Local).AddTicks(7639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 21, 59, 9, 42, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthorPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(4642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 44, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 532, DateTimeKind.Utc).AddTicks(8427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 4, 18, 59, 9, 43, DateTimeKind.Utc).AddTicks(801));
        }
    }
}
