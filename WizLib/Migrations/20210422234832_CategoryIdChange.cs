using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib.Migrations
{
    public partial class CategoryIdChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category_Id",
                table: "tbl_category",
                newName: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "tbl_category",
                newName: "Category_Id");
        }
    }
}
