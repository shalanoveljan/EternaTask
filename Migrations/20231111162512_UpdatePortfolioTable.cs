using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaTask.Migrations
{
    public partial class UpdatePortfolioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Page_Services");

            migrationBuilder.AddColumn<string>(
                name: "Client",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectURL",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Project_date",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Client",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ProjectURL",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Project_date",
                table: "Portfolios");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Page_Services",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);
        }
    }
}
