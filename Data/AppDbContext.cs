using ECommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Orderdetails> Orderdetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Orderdetails>().HasKey(o => o.orderId);
            modelBuilder.Entity<Orderdetails>().HasKey(o => o.productId);
            modelBuilder.Entity<Orderdetails>().HasKey(o => o.customerId);
        }
    }
}
