using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MouseMingle.Migrations
{
    public partial class UpdateRodentSeedDateProfilPicPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 1,
                column: "ProfilePic",
                value: "~/profiles/scorpo.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 2,
                column: "ProfilePic",
                value: "~/profiles/cadder.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 3,
                column: "ProfilePic",
                value: "~/profiles/flippy.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 4,
                column: "ProfilePic",
                value: "~/profiles/patty.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 5,
                column: "ProfilePic",
                value: "~/profiles/alfred.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 6,
                column: "ProfilePic",
                value: "~/profiles/rubin.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 7,
                column: "ProfilePic",
                value: "~/profiles/arthur.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 8,
                column: "ProfilePic",
                value: "~/profiles/squanker.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 9,
                column: "ProfilePic",
                value: "~/profiles/daddy.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 10,
                column: "ProfilePic",
                value: "~/profiles/housemouse.gif");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 1,
                column: "ProfilePic",
                value: "./wwwroot/imgs/scorpo.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 2,
                column: "ProfilePic",
                value: "./wwwroot/imgs/cadder.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 3,
                column: "ProfilePic",
                value: "./wwwroot/imgs/flippy.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 4,
                column: "ProfilePic",
                value: "./wwwroot/imgs/patty.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 5,
                column: "ProfilePic",
                value: "./wwwroot/imgs/alfred.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 6,
                column: "ProfilePic",
                value: "./wwwroot/imgs/rubin.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 7,
                column: "ProfilePic",
                value: "./wwwroot/imgs/arthur.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 8,
                column: "ProfilePic",
                value: "./wwwroot/imgs/squanker.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 9,
                column: "ProfilePic",
                value: "./wwwroot/imgs/daddy.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 10,
                column: "ProfilePic",
                value: "./wwwroot/imgs/housemouse.gif");
        }
    }
}
