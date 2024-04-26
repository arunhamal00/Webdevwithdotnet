using Microsoft.EntityFrameworkCore;

public class collegeDbContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=collegeMonitor.db");
    }
}