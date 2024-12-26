using Microsoft.EntityFrameworkCore;
using NorthwindMVC.Models;

namespace NorthwindMVC.Repository
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product>  Products { get; set; }
    }
}
