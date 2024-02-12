﻿// <auto-generated />
using Admin.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Admin.Persistence.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Admin.Domain.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Name = "Bogota"
                        },
                        new
                        {
                            CityId = 2,
                            Name = "Medellin"
                        },
                        new
                        {
                            CityId = 3,
                            Name = "Cali"
                        },
                        new
                        {
                            CityId = 4,
                            Name = "Cartagena"
                        },
                        new
                        {
                            CityId = 5,
                            Name = "Bucaramanga"
                        });
                });

            modelBuilder.Entity("Admin.Domain.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("Enabled")
                        .HasColumnType("int");

                    b.Property<int>("HotelTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            HotelId = 1,
                            Address = "Direccion Hotel 1",
                            CityId = 1,
                            Enabled = 1,
                            HotelTypeId = 1,
                            Name = "Hotel 1",
                            Phone = "2670011"
                        },
                        new
                        {
                            HotelId = 2,
                            Address = "Direccion Hotel 2",
                            CityId = 2,
                            Enabled = 1,
                            HotelTypeId = 2,
                            Name = "Hotel 2",
                            Phone = "2670012"
                        },
                        new
                        {
                            HotelId = 3,
                            Address = "Direccion Hotel 3",
                            CityId = 3,
                            Enabled = 1,
                            HotelTypeId = 3,
                            Name = "Hotel 3",
                            Phone = "2670013"
                        },
                        new
                        {
                            HotelId = 4,
                            Address = "Direccion Hotel 4",
                            CityId = 4,
                            Enabled = 1,
                            HotelTypeId = 4,
                            Name = "Hotel 4",
                            Phone = "2670014"
                        },
                        new
                        {
                            HotelId = 5,
                            Address = "Direccion Hotel 5",
                            CityId = 5,
                            Enabled = 1,
                            HotelTypeId = 5,
                            Name = "Hotel 5",
                            Phone = "2670015"
                        });
                });

            modelBuilder.Entity("Admin.Domain.HotelType", b =>
                {
                    b.Property<int>("HotelTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelTypeId"), 1L, 1);

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.HasKey("HotelTypeId");

                    b.ToTable("HotelTypes");

                    b.HasData(
                        new
                        {
                            HotelTypeId = 1,
                            Star = 1
                        },
                        new
                        {
                            HotelTypeId = 2,
                            Star = 2
                        },
                        new
                        {
                            HotelTypeId = 3,
                            Star = 3
                        },
                        new
                        {
                            HotelTypeId = 4,
                            Star = 4
                        },
                        new
                        {
                            HotelTypeId = 5,
                            Star = 5
                        });
                });

            modelBuilder.Entity("Admin.Domain.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"), 1L, 1);

                    b.Property<double>("BasePrice")
                        .HasColumnType("float");

                    b.Property<int>("Enabled")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<int>("IdHotel")
                        .HasColumnType("int");

                    b.Property<int>("IdRoomType")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            BasePrice = 40000.0,
                            Enabled = 1,
                            Floor = 1,
                            IdHotel = 1,
                            IdRoomType = 1,
                            RoomNumber = 101,
                            Tax = 7600.0
                        },
                        new
                        {
                            RoomId = 2,
                            BasePrice = 60000.0,
                            Enabled = 1,
                            Floor = 2,
                            IdHotel = 2,
                            IdRoomType = 2,
                            RoomNumber = 204,
                            Tax = 11400.0
                        },
                        new
                        {
                            RoomId = 3,
                            BasePrice = 75000.0,
                            Enabled = 1,
                            Floor = 3,
                            IdHotel = 3,
                            IdRoomType = 3,
                            RoomNumber = 308,
                            Tax = 14250.0
                        },
                        new
                        {
                            RoomId = 4,
                            BasePrice = 110000.0,
                            Enabled = 1,
                            Floor = 4,
                            IdHotel = 4,
                            IdRoomType = 4,
                            RoomNumber = 406,
                            Tax = 20900.0
                        },
                        new
                        {
                            RoomId = 5,
                            BasePrice = 160000.0,
                            Enabled = 1,
                            Floor = 5,
                            IdHotel = 5,
                            IdRoomType = 5,
                            RoomNumber = 502,
                            Tax = 30400.0
                        });
                });

            modelBuilder.Entity("Admin.Domain.RoomType", b =>
                {
                    b.Property<int>("RoomTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomTypeId"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomTypeId");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            RoomTypeId = 1,
                            Capacity = 6,
                            Name = "Suite Familiar"
                        },
                        new
                        {
                            RoomTypeId = 2,
                            Capacity = 3,
                            Name = "Habitacion Triple"
                        },
                        new
                        {
                            RoomTypeId = 3,
                            Capacity = 4,
                            Name = "Habitacion con Terraza"
                        },
                        new
                        {
                            RoomTypeId = 4,
                            Capacity = 1,
                            Name = "Habitacion Individual"
                        },
                        new
                        {
                            RoomTypeId = 5,
                            Capacity = 2,
                            Name = "Habitacion Doble"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
