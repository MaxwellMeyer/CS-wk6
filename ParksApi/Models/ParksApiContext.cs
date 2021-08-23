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
          new Park { ParkId = 1, Name = "Moran St. Park", Description = "A beautiful park on Orcas Island, featuring Mt. Constitution, the highest peak in the San Juan Islands, and several pristine lakes.", Facilities = "Camping, Boat rentals, Restroom/Showers", Region = "Orcas Island/SJI", Stats = "Yearly visitors: 10,000" },

          new Park { ParkId = 2, Name = "BLIND ISLAND MARINE STATE PARK", Description = "Tiny Blind Island is full of intrigue. Can you imagine finding a chunk of rock in the middle of a salty strait, staking a claim and planting an orchard there? A cluster of 19th-century sour apple trees and two formerly freshwater wells offer evidence of early farming on Blind Island.", Facilities = "Camping, Restroom/Showers", Region = "SJI", Stats = "Yearly virsitors: 1,000" },

          new Park { ParkId = 3, Name = "A totally real Park", Description = "A beautiful park, you will simply not believe how amazing it is", Facilities = "Camping, Restroom/Showers", Region = "Unknown", Stats = "Yearly visitors: 100,000" },

          new Park { ParkId = 4, Name = "DECEPTION PASS STATE PARK", Description = "Deception Pass is Washington's most-visited state park for a reason. Mysterious coves, rugged cliffs, jaw-dropping sunsets, and a stomach-dropping high bridge make this park a go-to for locals and international travelers alike.", Facilities = "Camping, Restroom/Showers", Region = "Anacortes/Whidbey", Stats = "Yearly visitors: 55,000" },

          new Park { ParkId = 5, Name = "SQUAK MOUNTAIN STATE PARK", Description = "Meander through the forest past bubbling creeks, mossy rocks and trees dripping with lichen. Ramble down the Bullitt Fireplace Trail to see the impressive remains of the 1952 Bullitt House's stone fireplace.", Facilities = "Restrooms", Region = "Seattle", Stats = "Yearly visitors: 25,000" },

          new Park { ParkId = 6, Name = "TRITON COVE", Description = "Known for dramatic daybreaks on clear mornings, this tiny day-use park is quieter than its northern neighbor, Dosewallips State Park. Triton Cove's well-maintained, ADA-accessible boat launch also makes this a prime spot for in-season fishing and crabbing – and you can fish all day long.", Facilities = "Camping, Boat rentals, Fishing, Restroom/Showers", Region = "Hood Canal", Stats = "Yearly visitors: 7,000" },

          new Park { ParkId = 7, Name = "PACIFIC BEACH STATE PARK", Description = "This small camping park northwest of Aberdeen features waterfront tent sites, yurts and RV hookups, so the fun doesn't have to end at sundown. Make a small fire on the beach (be sure it's more than 100 feet from vegetation), roast up some s'mores and watch the evening sky turn blue and then black with stars - or gray with storm clouds.", Facilities = "Camping, Restrooms", Region = "Aberdeen", Stats = "Yearly visitors: 1,000" }
        );
    }
  }
}