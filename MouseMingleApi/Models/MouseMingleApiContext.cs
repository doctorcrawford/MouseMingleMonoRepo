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
        new Rodent { RodentId = 1, Species = "Rat", Name = "Scorpo Fangoria", Age = 43, Location = "Fishermans Warf No.3", ProfilePic = "./imagePath.img"},
        new Rodent { RodentId = 2, Species = "Rat", Name = "Cadder Jenks", Age = 33, Location = "In a van down by the river", ProfilePic ="./imagePath.img"},
        new Rodent { RodentId = 3, Species = "Mouse", Name = "Flippy Twitch", Age = 3, Location = "hole", ProfilePic = "./iumagePath.img"}
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
        new Interest { InterestId = 10, Description = "Bye"}
      );
  }
}