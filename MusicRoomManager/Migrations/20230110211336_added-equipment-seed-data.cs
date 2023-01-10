using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicRoomManager.Migrations
{
    public partial class addedequipmentseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Brand", "IsAvailable", "Model", "Type" },
                values: new object[,]
                {
                    { 1, "Fender", true, "Stratocaster", 0 },
                    { 2, "Gibson", true, "Les Paul", 0 },
                    { 3, "Taylor", true, "214ce", 1 },
                    { 4, "Fender", true, "Telecaster", 0 },
                    { 5, "Yamaha", true, "Clavinova", 3 },
                    { 6, "Line6", true, "JTV-89F", 0 },
                    { 7, "Fender", true, "Mustang GTX-100", 5 },
                    { 8, "Mesa", true, "Boogie Mark V", 5 },
                    { 9, "Schecter", true, "Stiletto Stealth 4", 2 },
                    { 10, "Roland", true, "VAD 706", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
