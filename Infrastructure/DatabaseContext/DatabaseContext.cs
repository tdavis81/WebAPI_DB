using Microsoft.EntityFrameworkCore;
using WebAPI_DB.Infrastructure.Entities;

namespace WebAPI_DB.Infrastructure.DatabaseContext
{
    public partial class DatabaseContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DatabaseContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("Database");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
