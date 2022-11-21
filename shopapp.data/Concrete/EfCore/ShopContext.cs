using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class ShopContext : DbContext // DbContexten inherit edilir
    {
        // ürün ve kategori sýnýf iþlemleri
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        // deneme amaçlý yapýlan database baðlantýsý
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=shopDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(c => new { c.CategoryId, c.ProductId });
        }*/


    }
}