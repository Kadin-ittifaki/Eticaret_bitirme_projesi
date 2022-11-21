using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class ShopContext : DbContext // DbContexten inherit edilir
    {
        // �r�n ve kategori s�n�f i�lemleri
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        // deneme ama�l� yap�lan database ba�lant�s�
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