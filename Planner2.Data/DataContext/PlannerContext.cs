using Microsoft.EntityFrameworkCore;
using Planner2.Data.Models;

namespace Planner2.Data.DataContext;

public class PlannerContext : DbContext
{
    public PlannerContext(DbContextOptions<PlannerContext> options) : base(options)
    {
    }

    public DbSet<Users> Users { get; set; }
    //public DbSet<UserCredentials> UserCredentials { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<User>()
        //    .HasOne(u => u.UserCredentials)
        //    .WithOne(uc => uc.User)
        //    .HasForeignKey<UserCredentials>(uc => uc.UserId);
    }
}
