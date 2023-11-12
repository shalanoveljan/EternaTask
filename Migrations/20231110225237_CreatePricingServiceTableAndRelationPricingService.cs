using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaTask.Migrations
{
    public partial class CreatePricingServiceTableAndRelationPricingService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PricingService_Pricings_PricingId",
                table: "PricingService");

            migrationBuilder.DropForeignKey(
                name: "FK_PricingService_Services_ServiceId",
                table: "PricingService");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PricingService",
                table: "PricingService");

            migrationBuilder.RenameTable(
                name: "PricingService",
                newName: "PricingServices");

            migrationBuilder.RenameIndex(
                name: "IX_PricingService_ServiceId",
                table: "PricingServices",
                newName: "IX_PricingServices_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_PricingService_PricingId",
                table: "PricingServices",
                newName: "IX_PricingServices_PricingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PricingServices",
                table: "PricingServices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PricingServices_Pricings_PricingId",
                table: "PricingServices",
                column: "PricingId",
                principalTable: "Pricings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PricingServices_Services_ServiceId",
                table: "PricingServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PricingServices_Pricings_PricingId",
                table: "PricingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_PricingServices_Services_ServiceId",
                table: "PricingServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PricingServices",
                table: "PricingServices");

            migrationBuilder.RenameTable(
                name: "PricingServices",
                newName: "PricingService");

            migrationBuilder.RenameIndex(
                name: "IX_PricingServices_ServiceId",
                table: "PricingService",
                newName: "IX_PricingService_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_PricingServices_PricingId",
                table: "PricingService",
                newName: "IX_PricingService_PricingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PricingService",
                table: "PricingService",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PricingService_Pricings_PricingId",
                table: "PricingService",
                column: "PricingId",
                principalTable: "Pricings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PricingService_Services_ServiceId",
                table: "PricingService",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id");
        }
    }
}
