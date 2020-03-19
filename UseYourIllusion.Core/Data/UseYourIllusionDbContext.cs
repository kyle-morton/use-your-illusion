using Microsoft.EntityFrameworkCore;
using UseYourIllusion.Core.Data.Models;

namespace UseYourIllusion.Core.Data
{
    public class UseYourIllusionDbContext : DbContext
    {

        public UseYourIllusionDbContext(DbContextOptions<UseYourIllusionDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderAddress> OrderAddresses { get; set; }
        public DbSet<OrderShipment> OrderShipments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

    }
}
