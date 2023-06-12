using Microsoft.EntityFrameworkCore;


namespace MouseMingle.Models;

public class MouseMingleContext : DbContext
{
  public DbSet<Rat> Rats { get; set; }
}