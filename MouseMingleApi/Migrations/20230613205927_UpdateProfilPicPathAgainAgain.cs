using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MouseMingle.Migrations
{
    public partial class UpdateProfilPicPathAgainAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 1,
                column: "ProfilePic",
                value: "/img/scorpo.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 2,
                column: "ProfilePic",
                value: "/img/cadder.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 3,
                column: "ProfilePic",
                value: "/img/flippy.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 4,
                column: "ProfilePic",
                value: "/img/patty.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 5,
                column: "ProfilePic",
                value: "/img/alfred.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 6,
                column: "ProfilePic",
                value: "/img/rubin.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 7,
                column: "ProfilePic",
                value: "/img/arthur.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 8,
                column: "ProfilePic",
                value: "/img/squanker.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 9,
                column: "ProfilePic",
                value: "/img/daddy.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 10,
                column: "ProfilePic",
                value: "/img/housemouse.gif");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 1,
                column: "ProfilePic",
                value: "~/img/scorpo.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 2,
                column: "ProfilePic",
                value: "~/img/cadder.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 3,
                column: "ProfilePic",
                value: "~/img/flippy.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 4,
                column: "ProfilePic",
                value: "~/img/patty.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 5,
                column: "ProfilePic",
                value: "~/img/alfred.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 6,
                column: "ProfilePic",
                value: "~/img/rubin.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 7,
                column: "ProfilePic",
                value: "~/img/arthur.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 8,
                column: "ProfilePic",
                value: "~/img/squanker.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 9,
                column: "ProfilePic",
                value: "~/img/daddy.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 10,
                column: "ProfilePic",
                value: "~/img/housemouse.gif");
        }
    }
}
