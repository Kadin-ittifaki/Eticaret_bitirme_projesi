using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        // seed = tohum. 
        public static void Seed()
        {
            // al��veri� i�eri�i 
            var context = new ShopContext();
            // al��veri� i�eri�inin database taraf�ndan i�lenmesi
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
            }
            context.SaveChanges();
        }
        // hata var

        /*private static Category[] Categories = {
            new Category(){Name="Telefon"},
            new Category(){Name="Bilgisayar"},
            new Category(){Name="Elektronik"}
        };

        private static Product[] Products = {
            new Product(){Name="Samsung S5",Price=2000,ImageUrl="1.jpg",Description="iyi telefon", IsApproved=true},
            new Product(){Name="Samsung S6",Price=3000,ImageUrl="2.jpg",Description="iyi telefon", IsApproved=false},
            new Product(){Name="Samsung S7",Price=4000,ImageUrl="3.jpg",Description="iyi telefon", IsApproved=true},
            new Product(){Name="Samsung S8",Price=5000,ImageUrl="4.jpg",Description="iyi telefon", IsApproved=false},
            new Product(){Name="Samsung S9",Price=6000,ImageUrl="5.jpg",Description="iyi telefon", IsApproved=true},
        };*/
    }
}