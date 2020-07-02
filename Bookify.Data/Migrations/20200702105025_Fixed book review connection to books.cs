using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookify.Data.Migrations
{
    public partial class Fixedbookreviewconnectiontobooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Books_BookReviewedId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookReviewedId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookReviewedId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookReviewedId",
                table: "BookReviews",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookReviews_BookReviewedId",
                table: "BookReviews",
                column: "BookReviewedId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookReviews_Books_BookReviewedId",
                table: "BookReviews",
                column: "BookReviewedId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookReviews_Books_BookReviewedId",
                table: "BookReviews");

            migrationBuilder.DropIndex(
                name: "IX_BookReviews_BookReviewedId",
                table: "BookReviews");

            migrationBuilder.DropColumn(
                name: "BookReviewedId",
                table: "BookReviews");

            migrationBuilder.AddColumn<int>(
                name: "BookReviewedId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookReviewedId",
                table: "Books",
                column: "BookReviewedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Books_BookReviewedId",
                table: "Books",
                column: "BookReviewedId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
