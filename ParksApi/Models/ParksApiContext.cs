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
          new Park { ParkId = 2, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }, new Park { ParkId = 3, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }, new Park { ParkId = 4, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }, new Park { ParkId = 5, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }, new Park { ParkId = 6, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }, new Park { ParkId = 7, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly virsitors: 10,000" }
        );
    }
  }
}