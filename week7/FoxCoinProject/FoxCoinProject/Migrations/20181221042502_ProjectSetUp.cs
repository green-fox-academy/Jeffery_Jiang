using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoxCoinProject.Migrations
{
    public partial class ProjectSetUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Balance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "TransActions",
                columns: table => new
                {
                    TransId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromUserUserId = table.Column<long>(nullable: true),
                    ToUserUserId = table.Column<long>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransActions", x => x.TransId);
                    table.ForeignKey(
                        name: "FK_TransActions_UserAccounts_FromUserUserId",
                        column: x => x.FromUserUserId,
                        principalTable: "UserAccounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransActions_UserAccounts_ToUserUserId",
                        column: x => x.ToUserUserId,
                        principalTable: "UserAccounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransActions_FromUserUserId",
                table: "TransActions",
                column: "FromUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransActions_ToUserUserId",
                table: "TransActions",
                column: "ToUserUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransActions");

            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
