using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MouseMingle.Migrations
{
    public partial class AddRodentInterestJoinEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RodentInterests",
                columns: new[] { "RodentInterestId", "InterestId", "RodentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 6, 1 },
                    { 3, 2, 2 },
                    { 4, 3, 2 },
                    { 5, 4, 3 },
                    { 6, 5, 3 },
                    { 7, 10, 4 },
                    { 8, 8, 4 },
                    { 9, 9, 5 },
                    { 10, 7, 5 },
                    { 11, 2, 6 },
                    { 12, 7, 6 },
                    { 13, 9, 7 },
                    { 14, 1, 7 },
                    { 15, 5, 8 },
                    { 16, 3, 8 },
                    { 17, 10, 9 },
                    { 18, 7, 9 },
                    { 19, 2, 10 },
                    { 20, 8, 10 }
                });

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
                columns: new[] { "Name", "ProfilePic" },
                values: new object[] { "Big Daddy Crawford", "./wwwroot/imgs/daddy.gif" });

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 10,
                column: "ProfilePic",
                value: "./wwwroot/imgs/housemouse.gif");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RodentInterests",
                keyColumn: "RodentInterestId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 1,
                column: "ProfilePic",
                value: "./wwwroot/imgs/Scorpo.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 2,
                column: "ProfilePic",
                value: "./imagePath.img");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 3,
                column: "ProfilePic",
                value: "./imagePath.img");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 4,
                column: "ProfilePic",
                value: "./imagePath.img");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 5,
                column: "ProfilePic",
                value: "./imagePath.img");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 6,
                column: "ProfilePic",
                value: "./imagePath.img");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 7,
                column: "ProfilePic",
                value: "./imagePath.img");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 8,
                column: "ProfilePic",
                value: "./imagePath.img");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 9,
                columns: new[] { "Name", "ProfilePic" },
                values: new object[] { "Gyle Lawford", "./imagePath.img" });

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 10,
                column: "ProfilePic",
                value: "./imagePath.img");
        }
    }
}
