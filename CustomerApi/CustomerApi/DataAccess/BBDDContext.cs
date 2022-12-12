using CustomerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.DataAccess
{
    public class BBDDContext : DbContext
    {
        public BBDDContext(DbContextOptions<BBDDContext> options) : base(options)
        {

        }
        
        public DbSet<CustomerModel> CustomerModel { get; set; }
        public DbSet<ProductModel> ProductModel { get; set; }
        public DbSet<ProductOrdersModel> ProductOrdersModel { get; set; }

    }
}
