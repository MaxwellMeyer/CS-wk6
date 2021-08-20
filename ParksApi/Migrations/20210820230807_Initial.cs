using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Facilities = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Region = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Stats = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Facilities", "Name", "Region", "Stats" },
                values: new object[,]
                {
                    { 1, "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", "Camping, Boat rentals, Restroom/Showers", "Moran St. Park", "Orcas Island/SJI", "Yearly virsitors: 10,000" },
                    { 2, "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", "Camping, Boat rentals, Restroom/Showers", "Moran St. Park", "Orcas Island/SJI", "Yearly virsitors: 10,000" },
                    { 3, "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", "Camping, Boat rentals, Restroom/Showers", "Moran St. Park", "Orcas Island/SJI", "Yearly virsitors: 10,000" },
                    { 4, "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", "Camping, Boat rentals, Restroom/Showers", "Moran St. Park", "Orcas Island/SJI", "Yearly virsitors: 10,000" },
                    { 5, "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", "Camping, Boat rentals, Restroom/Showers", "Moran St. Park", "Orcas Island/SJI", "Yearly virsitors: 10,000" },
                    { 6, "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", "Camping, Boat rentals, Restroom/Showers", "Moran St. Park", "Orcas Island/SJI", "Yearly virsitors: 10,000" },
                    { 7, "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", "Camping, Boat rentals, Restroom/Showers", "Moran St. Park", "Orcas Island/SJI", "Yearly virsitors: 10,000" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
