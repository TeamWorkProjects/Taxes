using Microsoft.EntityFrameworkCore;

namespace taxes.services.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
        {
        }

        public DbSet<User> Users { get; set;}

    }
}