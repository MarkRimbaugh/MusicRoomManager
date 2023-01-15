using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicRoomManager.Migrations
{
    public partial class seedcustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "City", "DateOfBirth", "EmailAddress", "FirstName", "HomePhone", "LastName", "MobilePhone", "StateId", "Street1", "Street2", "Zip" },
                values: new object[,]
                {
                    { 1, "North Liberty", new DateTime(1982, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "bahsan@mail.com", "Bob", "555-456-5790", "Ahsan", "555-489-5749", 15, "1757 Hayes Drive", "Apt 138", "46508" },
                    { 2, "South Bend", new DateTime(1989, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "tchicurel@mail.com", "Tom", "555-456-4570", "Chicurel", "555-415-4368", 15, "3349 Bailey Highway", "NA", "49804" },
                    { 3, "Walkerton", new DateTime(1985, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ekoller@mail.com", "Elizabeth", "555-798-4596", "Koller", "555-789-4321", 15, "4502 Madison Drive", "Apt 3B", "46984" },
                    { 4, "Leesville", new DateTime(1979, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "shumphreys@mail.com", "Steve", "555-786-8975", "Humphreys", "555-249-5792", 19, "4565 Schroeder Forest Avenue", "NA", "68945" },
                    { 5, "Hope Mills", new DateTime(1972, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "rvoelkel@mail.com", "Rose", "555-970-1456", "Voelkel", "555-798-0465", 34, "9807 Henderson Road", "Apt 087", "89707" },
                    { 6, "Wasilla", new DateTime(1990, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ggreenfield@mail.com", "Grace", "555-579-5647", "Greenfield", "555-579-6780", 2, "27384 Martin Avenue", "NA", "16591" },
                    { 7, "Palmer", new DateTime(1977, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "jdiederich@mail.com", "Joe", "555-129-7980", "Diederich", "555-978-5706", 2, "4809 Witting Parkway", "NA", "98705" },
                    { 8, "Indianapolis", new DateTime(1980, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sstewart@mail.com", "Scott", "555-678-5794", "Stewart", "555-579-5749", 15, "321 Bradtke Ville", "Ste 101", "59498" },
                    { 9, "Lakeville", new DateTime(1962, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "griesman@mail.com", "Gina", "555-878-9713", "Riesman", "555-789-6498", 15, "28907 Erdman Points", "NA", "46898" },
                    { 10, "Mishawaka", new DateTime(1985, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "brhodes@mail.com", "Bill", "555-579-5914", "Rhodes", "555-789-8978", 15, "2417 Schmidt Drive", "NA", "49849" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
