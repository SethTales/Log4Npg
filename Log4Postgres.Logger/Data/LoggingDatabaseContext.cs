using Microsoft.EntityFrameworkCore;
using Log4Postgres.Models;

namespace Log4Postgres.Logger.Data
{
    public class LoggingDatabaseContext : DbContext
    {
        public LoggingDatabaseContext(DbContextOptions<LoggingDatabaseContext> options) : base(options)
        {

        }

        public DbSet<LogEntry> LogEntries {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<LogEntry>()
                .Property(l => l.Log)
                .HasColumnType("jsonb");
        }
    }
}