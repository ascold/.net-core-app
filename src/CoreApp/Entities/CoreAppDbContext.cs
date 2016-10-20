using Microsoft.EntityFrameworkCore;

namespace CoreApp.Entities
{
    public class CoreAppDbContext: DbContext
    {
        public CoreAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
