using Microsoft.EntityFrameworkCore;
using ShopManager.Entity.Models;

namespace ShopManager.Repository.Configuraciones.Persistencias
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        public virtual DbSet<User> USERS { get; set; }
        public virtual DbSet<Order> ORDERS { get; set; }
        public virtual DbSet<Product> PRODUCTS { get; set; }
        public virtual DbSet<OrderProduct> ORDER_PRODUCTS { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("ShopManagerDb");
            }
        }
    }
}
