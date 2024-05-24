using Microsoft.EntityFrameworkCore;
public class CollegeDbContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Session> Sessions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CollegeMonitor;Trusted_Connection=True;");
    }
}