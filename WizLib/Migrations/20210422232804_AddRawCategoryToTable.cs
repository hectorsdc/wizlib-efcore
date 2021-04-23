using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib.Migrations
{
    public partial class AddRawCategoryToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO tbl_category (CategoryName) VALUES('Cat 1')");
            migrationBuilder.Sql("INSERT INTO tbl_category (CategoryName) VALUES('Cat 2')");
            migrationBuilder.Sql("INSERT INTO tbl_category (CategoryName) VALUES('Cat 3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
