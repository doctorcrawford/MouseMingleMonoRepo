using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MouseMingle.Migrations
{
    public partial class AddScorpoGif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "InterestId", "Description" },
                values: new object[,]
                {
                    { 1, "Sipping water" },
                    { 2, "Styrofoam" },
                    { 3, "Old peanuts" },
                    { 4, "Long walks under the boardwalk" },
                    { 5, "Wet old towels" },
                    { 6, "Cheese scraps" },
                    { 7, "Meat sticks" },
                    { 8, "Shards" },
                    { 9, "Clam shells" },
                    { 10, "Dirt blood" }
                });

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 1,
                column: "ProfilePic",
                value: "./wwwroot/imgs/Scorpo.gif");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 3,
                columns: new[] { "Age", "ProfilePic" },
                values: new object[] { 18, "./imagePath.img" });

            migrationBuilder.InsertData(
                table: "Rodents",
                columns: new[] { "RodentId", "Age", "Location", "Name", "ProfilePic", "Species" },
                values: new object[,]
                {
                    { 4, 23, "hole", "Patty Valentine", "./imagePath.img", "Mouse" },
                    { 5, 58, "hole", "Alfred Bello Twitch", "./imagePath.img", "Naked Molerat" },
                    { 6, 19, "hole", "Rubin Carter", "./imagePath.img", "Ferret" },
                    { 7, 28, "hole", "Arthur Dexter Bradley", "./imagePath.img", "Capybara" },
                    { 8, 29, "hole", "Squanker Classic", "./imagePath.img", "Guinea Pig" },
                    { 9, 88, "hole", "Gyle Lawford", "./imagePath.img", "Myomorpha" },
                    { 10, 35, "hole", "House Mouse", "./imagePath.img", "Mus Musculus" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 1,
                column: "ProfilePic",
                value: "./imagePath.img");

            migrationBuilder.UpdateData(
                table: "Rodents",
                keyColumn: "RodentId",
                keyValue: 3,
                columns: new[] { "Age", "ProfilePic" },
                values: new object[] { 3, "./iumagePath.img" });
        }
    }
}
