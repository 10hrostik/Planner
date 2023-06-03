using Microsoft.EntityFrameworkCore;
using Planner.Models;

namespace Planner.Config;

public class PlannerContext : DbContext
{
    public DbSet<User>  Users { get; set; }
    private const string UrlConnection = @"Server=DESKTOP-DN63TT7\SQLExpress;Database=PlannerDB;Trusted_Connection=True;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(UrlConnection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
    }
}