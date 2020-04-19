using Microsoft.EntityFrameworkCore;
using SmartStoreNetCore.AppData.Models;

namespace SmartStoreNetCore.AppData
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) 
        {
        
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
