using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeApp.Migrations
{
    public partial class changeNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Ingredients",
                nullable: true,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Ingredients",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);
        }
    }
}
