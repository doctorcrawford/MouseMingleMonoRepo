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
  }
}