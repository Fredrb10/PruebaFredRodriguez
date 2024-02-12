using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admin.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelTypeId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enabled = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "HotelTypes",
                columns: table => new
                {
                    HotelTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Star = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTypes", x => x.HotelTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHotel = table.Column<int>(type: "int", nullable: false),
                    IdRoomType = table.Column<int>(type: "int", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<double>(type: "float", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    Enabled = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.RoomTypeId);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name" },
                values: new object[,]
                {
                    { 1, "Bogota" },
                    { 2, "Medellin" },
                    { 3, "Cali" },
                    { 4, "Cartagena" },
                    { 5, "Bucaramanga" }
                });

            migrationBuilder.InsertData(
                table: "HotelTypes",
                columns: new[] { "HotelTypeId", "Star" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "CityId", "Enabled", "HotelTypeId", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Direccion Hotel 1", 1, 1, 1, "Hotel 1", "2670011" },
                    { 2, "Direccion Hotel 2", 2, 1, 2, "Hotel 2", "2670012" },
                    { 3, "Direccion Hotel 3", 3, 1, 3, "Hotel 3", "2670013" },
                    { 4, "Direccion Hotel 4", 4, 1, 4, "Hotel 4", "2670014" },
                    { 5, "Direccion Hotel 5", 5, 1, 5, "Hotel 5", "2670015" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "RoomTypeId", "Capacity", "Name" },
                values: new object[,]
                {
                    { 1, 6, "Suite Familiar" },
                    { 2, 3, "Habitacion Triple" },
                    { 3, 4, "Habitacion con Terraza" },
                    { 4, 1, "Habitacion Individual" },
                    { 5, 2, "Habitacion Doble" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "BasePrice", "Enabled", "Floor", "IdHotel", "IdRoomType", "RoomNumber", "Tax" },
                values: new object[,]
                {
                    { 1, 40000.0, 1, 1, 1, 1, 101, 7600.0 },
                    { 2, 60000.0, 1, 2, 2, 2, 204, 11400.0 },
                    { 3, 75000.0, 1, 3, 3, 3, 308, 14250.0 },
                    { 4, 110000.0, 1, 4, 4, 4, 406, 20900.0 },
                    { 5, 160000.0, 1, 5, 5, 5, 502, 30400.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "HotelTypes");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
