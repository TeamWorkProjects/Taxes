using Microsoft.EntityFrameworkCore;
using taxes.services.Models;

namespace taxes.services.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
        {
        }

        public DbSet<User> Users { get; set;}
        public DbSet<User> Owner { get; set;}
        public DbSet<User> Address { get; set;}

    }
}