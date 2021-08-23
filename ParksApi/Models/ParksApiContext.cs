using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
  public class ParksApiContext : DbContext
  {
    public ParksApiContext(DbContextOptions<ParksApiContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" },
          new Park { ParkId = 2, Name = "BLIND ISLAND MARINE STATE PARK", Description = "Tiny Blind Island is full of intrigue. Can you imagine finding a chunk of rock in the middle of a salty strait, staking a claim and planting an orchard there? A cluster of 19th-century sour apple trees and two formerly freshwater wells offer evidence of early farming on Blind Island.", Facilities = "Camping, Restroom/Showers", Region = "SJI", Stats = "Yearly virsitors: 1,000" }, new Park { ParkId = 3, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }, new Park { ParkId = 4, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }, new Park { ParkId = 5, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }, new Park { ParkId = 6, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }, new Park { ParkId = 7, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }
        );
    }
  }
}