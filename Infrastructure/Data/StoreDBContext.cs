using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data
{
    public class StoreDBContext:DbContext
    {//option "connection string"

        //constructor
        public StoreDBContext(DbContextOptions<StoreDBContext> options ):base(options)
        {

        }

        //properties
        public DbSet<Product>products { get; set; }
    }
}
