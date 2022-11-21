using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
        // g�nderilen product nesnesinin listeleme i�lemleri ger�ekle�tirilecek
       List<Product> GetPopularProducts();
       List<Product> GetTop5Products();
    }
}