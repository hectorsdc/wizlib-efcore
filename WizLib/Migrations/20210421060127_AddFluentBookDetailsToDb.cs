﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib.Migrations
{
    public partial class AddFluentBookDetailsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fluent_BookDetails",
                columns: table => new
                {
                    BookDetail_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumberOfChapters = table.Column<int>(type: "int", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    Book_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_BookDetails", x => x.BookDetail_Id);
                    table.ForeignKey(
                        name: "FK_Fluent_BookDetails_Books_Book_Id",
                        column: x => x.Book_Id,
                        principalTable: "Books",
                        principalColumn: "Book_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_BookDetails");
        }
    }
}
