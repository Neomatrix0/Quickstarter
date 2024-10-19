using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quickstarter.Models;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    // protected override void OnConfiguring(DbContextOptionsBuilder option)
    // {
    //     option.UseSqlite("Data Source=app.db");
    // }

    public DbSet<Project> Projects { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<Contribution> Contributions { get; set; }
}
