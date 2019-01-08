using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeApp.Migrations
{
    public partial class addUnits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Ingredients",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Ingredients");
        }
    }
}
