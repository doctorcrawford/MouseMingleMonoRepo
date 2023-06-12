using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MouseMingle.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    InterestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.InterestId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rodents",
                columns: table => new
                {
                    RodentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Species = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfilePic = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rodents", x => x.RodentId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RodentInterests",
                columns: table => new
                {
                    RodentInterestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RodentId = table.Column<int>(type: "int", nullable: false),
                    InterestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RodentInterests", x => x.RodentInterestId);
                    table.ForeignKey(
                        name: "FK_RodentInterests_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "InterestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RodentInterests_Rodents_RodentId",
                        column: x => x.RodentId,
                        principalTable: "Rodents",
                        principalColumn: "RodentId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Rodents",
                columns: new[] { "RodentId", "Age", "Location", "Name", "ProfilePic", "Species" },
                values: new object[] { 1, 43, "Fishermans Warf No.3", "Scorpo Fangoria", "./imagePath.img", "Rat" });

            migrationBuilder.InsertData(
                table: "Rodents",
                columns: new[] { "RodentId", "Age", "Location", "Name", "ProfilePic", "Species" },
                values: new object[] { 2, 33, "In a van down by the river", "Cadder Jenks", "./imagePath.img", "Rat" });

            migrationBuilder.InsertData(
                table: "Rodents",
                columns: new[] { "RodentId", "Age", "Location", "Name", "ProfilePic", "Species" },
                values: new object[] { 3, 3, "hole", "Flippy Twitch", "./iumagePath.img", "Mouse" });

            migrationBuilder.CreateIndex(
                name: "IX_RodentInterests_InterestId",
                table: "RodentInterests",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_RodentInterests_RodentId",
                table: "RodentInterests",
                column: "RodentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RodentInterests");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Rodents");
        }
    }
}
