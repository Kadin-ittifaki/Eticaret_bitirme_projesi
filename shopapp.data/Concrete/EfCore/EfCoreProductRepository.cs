using System.Collections.Generic;
using System.Linq;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : 
        EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        // �r�nleri liste �eklinde geriye d�nd�r�r.
        public List<Product> GetPopularProducts()
        {
            using(var context = new ShopContext())
            {
                return context.Products.ToList();
            }
        }
        // listelemede olu�abilecek hatalar i�in, hata f�rlatma metodu
        public List<Product> GetTop5Products()
        {
            throw new System.NotImplementedException();
        }
    }
}