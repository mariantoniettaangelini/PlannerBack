using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Planner2.Data.Models;

namespace Planner2.Data.DataContext;

public class PlannerContext : DbContext
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;
    public PlannerContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("Database");
    }
    public DbSet<User> Users { get; set; }
    public DbSet<UserCredentials> UserCredentials { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(_connectionString);
    }
}
