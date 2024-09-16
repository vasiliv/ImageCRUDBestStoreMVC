using ImageCRUDBestStoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageCRUDBestStoreMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Product>Products { get; set; }
    }
}
