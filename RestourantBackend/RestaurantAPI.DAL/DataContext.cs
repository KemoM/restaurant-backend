using Microsoft.EntityFrameworkCore;
using RestaurantAPI.DAL.Entities;

namespace RestaurantAPI.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
