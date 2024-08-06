using Microsoft.EntityFrameworkCore;

namespace HandsOnApiUsingEFCodeFirst.Entities
{
    public class ECommContext : DbContext
    {
        //Entity Set for User and Product
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        //Configure ConnectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("data source=sanjaydell\\sqlexpress;initial catalog=ecomm;integrated security=true;trust server certificate=true");
        }
        
    }
}
