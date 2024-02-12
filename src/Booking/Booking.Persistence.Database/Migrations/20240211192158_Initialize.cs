using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvailableHotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    Hotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    DocumentNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentificationTypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentificationTypes", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Birthdate", "DocumentNumber", "DocumentType", "Email", "EmergencyContact", "EmergencyContactPhone", "Gender", "LastName", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 11, 14, 21, 58, 649, DateTimeKind.Local).AddTicks(1867), 102078256, 1, "Juan.P@hotmail.com", "Maria Rodriguez", "5256024", "M", "Perez", "Juan", "3135026" },
                    { 2, new DateTime(2024, 2, 11, 14, 21, 58, 649, DateTimeKind.Local).AddTicks(1877), 17896582, 1, "JuanA.G@hotmail.com", "Carlos Rodriguez", "8956225", "F", "Garces", "Sofia", "258782" }
                });

            migrationBuilder.InsertData(
                table: "IdentificationTypes",
                columns: new[] { "TypeId", "Type" },
                values: new object[,]
                {
                    { 1, "Cedula Ciudadania" },
                    { 2, "Pasaporte" },
                    { 3, "Tarjeta Identidad" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "AdmissionDate", "CustomerId", "DepartureDate", "HotelId", "RoomId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 11, 14, 21, 58, 649, DateTimeKind.Local).AddTicks(2551), 102078256, new DateTime(2024, 2, 13, 14, 21, 58, 649, DateTimeKind.Local).AddTicks(2553), 1, 5 },
                    { 2, new DateTime(2024, 2, 11, 14, 21, 58, 649, DateTimeKind.Local).AddTicks(2560), 17896582, new DateTime(2024, 2, 13, 14, 21, 58, 649, DateTimeKind.Local).AddTicks(2561), 1, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvailableHotels");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "IdentificationTypes");

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
