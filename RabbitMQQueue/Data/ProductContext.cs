using Microsoft.EntityFrameworkCore;
using RabbitMQQueue.Models;

namespace RabbitMQQueue.Data
{
    //Run following commands in Package manager console
    //add-migration “first”
    //update-database

    public class ProductContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public ProductContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Product> Products
        {
            get;
            set;
        }

    }
}
