using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITBlog.DataAccess.Migrations
{
    public partial class manytomanyrelationShipsReCreatedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPlace_tblCategory_CategoryId",
                table: "CategoryPlace");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPlace_tblPlace_PlaceId",
                table: "CategoryPlace");

            migrationBuilder.DropForeignKey(
                name: "FK_tblAuthorPicture_tblAuthor_Id",
                table: "tblAuthorPicture");

            migrationBuilder.DropForeignKey(
                name: "FK_tblAuthorPicture_tblPicture_Id",
                table: "tblAuthorPicture");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostCategoryMapping_tblCategory_Id",
                table: "tblPostCategoryMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostCategoryMapping_tblPost_Id",
                table: "tblPostCategoryMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostPictureMapping_tblPicture_Id",
                table: "tblPostPictureMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostPictureMapping_tblPost_Id",
                table: "tblPostPictureMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostPlace_tblPlace_Id",
                table: "tblPostPlace");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostPlace_tblPost_Id",
                table: "tblPostPlace");

            migrationBuilder.DropIndex(
                name: "IX_tblPostPlace_Id",
                table: "tblPostPlace");

            migrationBuilder.DropIndex(
                name: "IX_tblPostPictureMapping_Id",
                table: "tblPostPictureMapping");

            migrationBuilder.DropIndex(
                name: "IX_tblPostCategoryMapping_Id",
                table: "tblPostCategoryMapping");

            migrationBuilder.DropIndex(
                name: "IX_tblAuthorPicture_Id",
                table: "tblAuthorPicture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryPlace",
                table: "CategoryPlace");

            migrationBuilder.DropIndex(
                name: "IX_CategoryPlace_CategoryId",
                table: "CategoryPlace");

            migrationBuilder.RenameTable(
                name: "CategoryPlace",
                newName: "tblCategoryPlaceMapping");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryPlace_PlaceId",
                table: "tblCategoryPlaceMapping",
                newName: "IX_tblCategoryPlaceMapping_PlaceId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(1011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 993, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPictureMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(3391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 992, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostCategoryMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(7170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 992, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 532, DateTimeKind.Utc).AddTicks(6695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(1196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 16, 55, 54, 532, DateTimeKind.Local).AddTicks(7639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 16, 47, 16, 991, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthorPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(4642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 993, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 532, DateTimeKind.Utc).AddTicks(8427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "tblCategoryPlaceMapping",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "tblCategoryPlaceMapping",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategoryPlaceMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(8270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblCategoryPlaceMapping",
                table: "tblCategoryPlaceMapping",
                columns: new[] { "CategoryId", "PlaceId" });

            migrationBuilder.CreateIndex(
                name: "IX_tblPostPlace_PlaceId",
                table: "tblPostPlace",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostPictureMapping_PictureId",
                table: "tblPostPictureMapping",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostCategoryMapping_CategoryId",
                table: "tblPostCategoryMapping",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuthorPicture_PictureId",
                table: "tblAuthorPicture",
                column: "PictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuthorPicture_tblAuthor_AuthorId",
                table: "tblAuthorPicture",
                column: "AuthorId",
                principalTable: "tblAuthor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuthorPicture_tblPicture_PictureId",
                table: "tblAuthorPicture",
                column: "PictureId",
                principalTable: "tblPicture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblCategoryPlaceMapping_tblCategory_CategoryId",
                table: "tblCategoryPlaceMapping",
                column: "CategoryId",
                principalTable: "tblCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblCategoryPlaceMapping_tblPlace_PlaceId",
                table: "tblCategoryPlaceMapping",
                column: "PlaceId",
                principalTable: "tblPlace",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostCategoryMapping_tblCategory_CategoryId",
                table: "tblPostCategoryMapping",
                column: "CategoryId",
                principalTable: "tblCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostCategoryMapping_tblPost_PostId",
                table: "tblPostCategoryMapping",
                column: "PostId",
                principalTable: "tblPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostPictureMapping_tblPicture_PictureId",
                table: "tblPostPictureMapping",
                column: "PictureId",
                principalTable: "tblPicture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostPictureMapping_tblPost_PostId",
                table: "tblPostPictureMapping",
                column: "PostId",
                principalTable: "tblPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostPlace_tblPlace_PlaceId",
                table: "tblPostPlace",
                column: "PlaceId",
                principalTable: "tblPlace",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostPlace_tblPost_PostId",
                table: "tblPostPlace",
                column: "PostId",
                principalTable: "tblPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblAuthorPicture_tblAuthor_AuthorId",
                table: "tblAuthorPicture");

            migrationBuilder.DropForeignKey(
                name: "FK_tblAuthorPicture_tblPicture_PictureId",
                table: "tblAuthorPicture");

            migrationBuilder.DropForeignKey(
                name: "FK_tblCategoryPlaceMapping_tblCategory_CategoryId",
                table: "tblCategoryPlaceMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_tblCategoryPlaceMapping_tblPlace_PlaceId",
                table: "tblCategoryPlaceMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostCategoryMapping_tblCategory_CategoryId",
                table: "tblPostCategoryMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostCategoryMapping_tblPost_PostId",
                table: "tblPostCategoryMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostPictureMapping_tblPicture_PictureId",
                table: "tblPostPictureMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostPictureMapping_tblPost_PostId",
                table: "tblPostPictureMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostPlace_tblPlace_PlaceId",
                table: "tblPostPlace");

            migrationBuilder.DropForeignKey(
                name: "FK_tblPostPlace_tblPost_PostId",
                table: "tblPostPlace");

            migrationBuilder.DropIndex(
                name: "IX_tblPostPlace_PlaceId",
                table: "tblPostPlace");

            migrationBuilder.DropIndex(
                name: "IX_tblPostPictureMapping_PictureId",
                table: "tblPostPictureMapping");

            migrationBuilder.DropIndex(
                name: "IX_tblPostCategoryMapping_CategoryId",
                table: "tblPostCategoryMapping");

            migrationBuilder.DropIndex(
                name: "IX_tblAuthorPicture_PictureId",
                table: "tblAuthorPicture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblCategoryPlaceMapping",
                table: "tblCategoryPlaceMapping");

            migrationBuilder.RenameTable(
                name: "tblCategoryPlaceMapping",
                newName: "CategoryPlace");

            migrationBuilder.RenameIndex(
                name: "IX_tblCategoryPlaceMapping_PlaceId",
                table: "CategoryPlace",
                newName: "IX_CategoryPlace_PlaceId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 993, DateTimeKind.Utc).AddTicks(3778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostPictureMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 992, DateTimeKind.Utc).AddTicks(435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPostCategoryMapping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 992, DateTimeKind.Utc).AddTicks(7094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(3241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 532, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPlace",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(8145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(7136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 533, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 16, 47, 16, 991, DateTimeKind.Local).AddTicks(4275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 16, 55, 54, 532, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthorPicture",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 993, DateTimeKind.Utc).AddTicks(9984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "tblAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 13, 47, 16, 991, DateTimeKind.Utc).AddTicks(5165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 532, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CategoryPlace",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CategoryPlace",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "CategoryPlace",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 13, 55, 54, 534, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryPlace",
                table: "CategoryPlace",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostPlace_Id",
                table: "tblPostPlace",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostPictureMapping_Id",
                table: "tblPostPictureMapping",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostCategoryMapping_Id",
                table: "tblPostCategoryMapping",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuthorPicture_Id",
                table: "tblAuthorPicture",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPlace_CategoryId",
                table: "CategoryPlace",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPlace_tblCategory_CategoryId",
                table: "CategoryPlace",
                column: "CategoryId",
                principalTable: "tblCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPlace_tblPlace_PlaceId",
                table: "CategoryPlace",
                column: "PlaceId",
                principalTable: "tblPlace",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuthorPicture_tblAuthor_Id",
                table: "tblAuthorPicture",
                column: "Id",
                principalTable: "tblAuthor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAuthorPicture_tblPicture_Id",
                table: "tblAuthorPicture",
                column: "Id",
                principalTable: "tblPicture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostCategoryMapping_tblCategory_Id",
                table: "tblPostCategoryMapping",
                column: "Id",
                principalTable: "tblCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostCategoryMapping_tblPost_Id",
                table: "tblPostCategoryMapping",
                column: "Id",
                principalTable: "tblPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostPictureMapping_tblPicture_Id",
                table: "tblPostPictureMapping",
                column: "Id",
                principalTable: "tblPicture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostPictureMapping_tblPost_Id",
                table: "tblPostPictureMapping",
                column: "Id",
                principalTable: "tblPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostPlace_tblPlace_Id",
                table: "tblPostPlace",
                column: "Id",
                principalTable: "tblPlace",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblPostPlace_tblPost_Id",
                table: "tblPostPlace",
                column: "Id",
                principalTable: "tblPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
