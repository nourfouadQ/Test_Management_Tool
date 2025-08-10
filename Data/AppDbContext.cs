using Microsoft.EntityFrameworkCore;
using TestManagementAPI.Models;

namespace TestManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<TestScenario> TestScenarios { get; set; }
        public DbSet<TestCase> TestCases { get; set; }
        public DbSet<Defect> Defects { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<Execution> Executions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Cycle> Cycles { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite key for UserRole
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
