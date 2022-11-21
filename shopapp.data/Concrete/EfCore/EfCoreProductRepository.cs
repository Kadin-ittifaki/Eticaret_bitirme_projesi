using System.Collections.Generic;
using System.Linq;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : 
        EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        // ürünleri liste þeklinde geriye döndürür.
        public List<Product> GetPopularProducts()
        {
            using(var context = new ShopContext())
            {
                return context.Products.ToList();
            }
        }
        // listelemede oluþabilecek hatalar için, hata fýrlatma metodu
        public List<Product> GetTop5Products()
        {
            throw new System.NotImplementedException();
        }
    }
}