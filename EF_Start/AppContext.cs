using EF_Start.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Start;

public class AppContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=TestDB; Trusted_Connection=false");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
