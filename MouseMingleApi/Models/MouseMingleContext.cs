using Microsoft.EntityFrameworkCore;


namespace MouseMingleApi.Models;

public class MouseMingleApiContext : DbContext
{
  public DbSet<Rat> Rats { get; set; }
}