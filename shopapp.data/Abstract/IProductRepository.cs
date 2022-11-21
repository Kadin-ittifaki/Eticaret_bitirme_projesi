using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
        // gönderilen product nesnesinin listeleme iþlemleri gerçekleþtirilecek
       List<Product> GetPopularProducts();
       List<Product> GetTop5Products();
    }
}