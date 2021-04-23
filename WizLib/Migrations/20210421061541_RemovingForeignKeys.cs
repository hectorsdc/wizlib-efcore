using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib.Migrations
{
    public partial class RemovingForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Fluent_Books_Fluent_BookBook_Id",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Fluent_Authors_Fluent_AuthorAuthor_Id",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Fluent_Publishers_Fluent_PublisherPublisher_Id",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetails_Books_Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_BookDetails_BookDetail_Id1",
                table: "Fluent_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Publishers_Publisher_Id1",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_BookDetail_Id1",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_Publisher_Id1",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_Books_Fluent_AuthorAuthor_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Fluent_PublisherPublisher_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Authors_Fluent_BookBook_Id",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "BookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "BookDetail_Id1",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Publisher_Id1",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropColumn(
                name: "Fluent_AuthorAuthor_Id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Fluent_PublisherPublisher_Id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Fluent_BookBook_Id",
                table: "Authors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookDetail_Id",
                table: "Fluent_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookDetail_Id1",
                table: "Fluent_Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id",
                table: "Fluent_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id1",
                table: "Fluent_Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "Fluent_BookDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fluent_AuthorAuthor_Id",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fluent_PublisherPublisher_Id",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fluent_BookBook_Id",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_BookDetail_Id1",
                table: "Fluent_Books",
                column: "BookDetail_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_Publisher_Id1",
                table: "Fluent_Books",
                column: "Publisher_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Fluent_AuthorAuthor_Id",
                table: "Books",
                column: "Fluent_AuthorAuthor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Fluent_PublisherPublisher_Id",
                table: "Books",
                column: "Fluent_PublisherPublisher_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Fluent_BookBook_Id",
                table: "Authors",
                column: "Fluent_BookBook_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Fluent_Books_Fluent_BookBook_Id",
                table: "Authors",
                column: "Fluent_BookBook_Id",
                principalTable: "Fluent_Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Fluent_Authors_Fluent_AuthorAuthor_Id",
                table: "Books",
                column: "Fluent_AuthorAuthor_Id",
                principalTable: "Fluent_Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Fluent_Publishers_Fluent_PublisherPublisher_Id",
                table: "Books",
                column: "Fluent_PublisherPublisher_Id",
                principalTable: "Fluent_Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetails_Books_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id",
                principalTable: "Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_BookDetails_BookDetail_Id1",
                table: "Fluent_Books",
                column: "BookDetail_Id1",
                principalTable: "BookDetails",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Publishers_Publisher_Id1",
                table: "Fluent_Books",
                column: "Publisher_Id1",
                principalTable: "Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
