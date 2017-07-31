using Microsoft.EntityFrameworkCore;

namespace BSACore.Models.Context
{
    public class LogContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public LogContext(DbContextOptions<LogContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>().ToTable("Logs");           
        }
    }
}
