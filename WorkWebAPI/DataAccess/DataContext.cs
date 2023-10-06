using Microsoft.EntityFrameworkCore;
using WorkWebAPI.Models;

namespace WorkWebAPI.DataAccess
{
    public class DataContext:DbContext
    {
        public DbSet<Work> Works { get; set; }
        public DbSet<User> Users { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
