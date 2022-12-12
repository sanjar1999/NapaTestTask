using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Contexts
{
    public sealed class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public ApplicationContext() { }

        public DbSet<User> AppUsers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
