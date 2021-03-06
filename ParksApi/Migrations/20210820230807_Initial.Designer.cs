// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

namespace ParksApi.Migrations
{
    [DbContext(typeof(ParksApiContext))]
    [Migration("20210820230807_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Facilities")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Region")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Stats")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.",
                            Facilities = "Camping, Boat rentals, Restroom/Showers",
                            Name = "Moran St. Park",
                            Region = "Orcas Island/SJI",
                            Stats = "Yearly virsitors: 10,000"
                        },
                        new
                        {
                            ParkId = 2,
                            Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.",
                            Facilities = "Camping, Boat rentals, Restroom/Showers",
                            Name = "Moran St. Park",
                            Region = "Orcas Island/SJI",
                            Stats = "Yearly virsitors: 10,000"
                        },
                        new
                        {
                            ParkId = 3,
                            Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.",
                            Facilities = "Camping, Boat rentals, Restroom/Showers",
                            Name = "Moran St. Park",
                            Region = "Orcas Island/SJI",
                            Stats = "Yearly virsitors: 10,000"
                        },
                        new
                        {
                            ParkId = 4,
                            Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.",
                            Facilities = "Camping, Boat rentals, Restroom/Showers",
                            Name = "Moran St. Park",
                            Region = "Orcas Island/SJI",
                            Stats = "Yearly virsitors: 10,000"
                        },
                        new
                        {
                            ParkId = 5,
                            Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.",
                            Facilities = "Camping, Boat rentals, Restroom/Showers",
                            Name = "Moran St. Park",
                            Region = "Orcas Island/SJI",
                            Stats = "Yearly virsitors: 10,000"
                        },
                        new
                        {
                            ParkId = 6,
                            Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.",
                            Facilities = "Camping, Boat rentals, Restroom/Showers",
                            Name = "Moran St. Park",
                            Region = "Orcas Island/SJI",
                            Stats = "Yearly virsitors: 10,000"
                        },
                        new
                        {
                            ParkId = 7,
                            Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.",
                            Facilities = "Camping, Boat rentals, Restroom/Showers",
                            Name = "Moran St. Park",
                            Region = "Orcas Island/SJI",
                            Stats = "Yearly virsitors: 10,000"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
