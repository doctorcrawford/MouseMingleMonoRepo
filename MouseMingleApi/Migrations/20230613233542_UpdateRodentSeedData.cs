using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MouseMingle.Migrations
{
    public partial class UpdateRodentSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 4,
                column: "Location",
                value: "Shoe");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 5,
                column: "Location",
                value: "Barrel of a gun");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 6,
                column: "Location",
                value: "Cave underneath a tire");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 7,
                column: "Location",
                value: "Dirt patch");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 8,
                column: "Location",
                value: "blade of grass");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 9,
                column: "Location",
                value: "In a nest made of a human hair");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 10,
                column: "Location",
                value: "Outback Steakhouse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 4,
                column: "Location",
                value: "hole");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 5,
                column: "Location",
                value: "hole");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 6,
                column: "Location",
                value: "hole");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 7,
                column: "Location",
                value: "hole");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 8,
                column: "Location",
                value: "hole");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 9,
                column: "Location",
                value: "hole");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 10,
                column: "Location",
                value: "hole");
        }
    }
}
