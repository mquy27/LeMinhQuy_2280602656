using Microsoft.EntityFrameworkCore;
using LeMinhQuy_2280602656_Tuan03.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LeMinhQuy_2280602656_Tuan03.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
