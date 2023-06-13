using Microsoft.EntityFrameworkCore;


namespace MouseMingleApi.Models;

public class MouseMingleApiContext : DbContext
{
  public DbSet<Rodent> Rodents { get; set; }
  public DbSet<Interest> Interests { get; set; }
  public DbSet<RodentInterest> RodentInterests { get; set; }

  public MouseMingleApiContext(DbContextOptions options) : base(options) {}

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Rodent>()
      .HasData(
        new Rodent { RodentId = 1, Species = "Rat", Name = "Scorpo Fangoria", Age = 43, Location = "Fishermans Warf No.3", ProfilePic = "/img/scorpo.gif" },
        new Rodent { RodentId = 2, Species = "Rat", Name = "Cadder Jenks", Age = 33, Location = "In a van down by the river", ProfilePic ="/img/cadder.gif" },
        new Rodent { RodentId = 3, Species = "Mouse", Name = "Flippy Twitch", Age = 18, Location = "hole", ProfilePic = "/img/flippy.gif" },
        new Rodent { RodentId = 4, Species = "Mouse", Name = "Patty Valentine", Age = 23, Location = "hole", ProfilePic = "/img/patty.gif" },
        new Rodent { RodentId = 5, Species = "Naked Molerat", Name = "Alfred Bello Twitch", Age = 58, Location = "hole", ProfilePic = "/img/alfred.gif" },
        new Rodent { RodentId = 6, Species = "Ferret", Name = "Rubin Carter", Age = 19, Location = "hole", ProfilePic = "/img/rubin.gif" },
        new Rodent { RodentId = 7, Species = "Capybara", Name = "Arthur Dexter Bradley", Age = 28, Location = "hole", ProfilePic = "/img/arthur.gif" },
        new Rodent { RodentId = 8, Species = "Guinea Pig", Name = "Squanker Classic", Age = 29, Location = "hole", ProfilePic = "/img/squanker.gif" },
        new Rodent { RodentId = 9, Species = "Myomorpha", Name = "Big Daddy Crawford", Age = 88, Location = "hole", ProfilePic = "/img/daddy.gif" },
        new Rodent { RodentId = 10, Species = "Mus Musculus", Name = "House Mouse", Age = 35, Location = "hole", ProfilePic = "/img/housemouse.gif" }
      );
    builder.Entity<Interest>()
      .HasData(
        new Interest { InterestId = 1, Description = "Sipping water"},
        new Interest { InterestId = 2, Description = "Styrofoam"},
        new Interest { InterestId = 3, Description = "Old peanuts"},
        new Interest { InterestId = 4, Description = "Long walks under the boardwalk"},
        new Interest { InterestId = 5, Description = "Wet old towels"},
        new Interest { InterestId = 6, Description = "Cheese scraps"},
        new Interest { InterestId = 7, Description = "Meat sticks"},
        new Interest { InterestId = 8, Description = "Shards"},
        new Interest { InterestId = 9, Description = "Clam shells"},
        new Interest { InterestId = 10, Description = "Dirt blood"}
      );

      builder.Entity<RodentInterest>()
        .HasData(
          new RodentInterest { RodentInterestId = 1, InterestId = 1, RodentId = 1 },
          new RodentInterest { RodentInterestId = 2, InterestId = 6, RodentId = 1 },
          new RodentInterest { RodentInterestId = 3, InterestId = 2, RodentId = 2 },
          new RodentInterest { RodentInterestId = 4, InterestId = 3, RodentId = 2 },
          new RodentInterest { RodentInterestId = 5, InterestId = 4, RodentId = 3 },
          new RodentInterest { RodentInterestId = 6, InterestId = 5, RodentId = 3 },
          new RodentInterest { RodentInterestId = 7, InterestId = 10, RodentId = 4 },
          new RodentInterest { RodentInterestId = 8, InterestId = 8, RodentId = 4 },
          new RodentInterest { RodentInterestId = 9, InterestId = 9, RodentId = 5 },
          new RodentInterest { RodentInterestId = 10, InterestId = 7, RodentId = 5 },
          new RodentInterest { RodentInterestId = 11, InterestId = 2, RodentId = 6 },
          new RodentInterest { RodentInterestId = 12, InterestId = 7, RodentId = 6 },
          new RodentInterest { RodentInterestId = 13, InterestId = 9, RodentId = 7 },
          new RodentInterest { RodentInterestId = 14, InterestId = 1, RodentId = 7 },
          new RodentInterest { RodentInterestId = 15, InterestId = 5, RodentId = 8 },
          new RodentInterest { RodentInterestId = 16, InterestId = 3, RodentId = 8 },
          new RodentInterest { RodentInterestId = 17, InterestId = 10, RodentId = 9 },
          new RodentInterest { RodentInterestId = 18, InterestId = 7, RodentId = 9 },
          new RodentInterest { RodentInterestId = 19, InterestId = 2, RodentId = 10 },
          new RodentInterest { RodentInterestId = 20, InterestId = 8, RodentId = 10}
        );
  }
}