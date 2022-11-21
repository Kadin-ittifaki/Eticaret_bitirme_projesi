using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IProductService
    {
        //Entity veritabanýmýz ile yazýlýmýmýz arasýnda
        //iliþki kurmamýzý saðlayan kalýcý nesnelerdir.

        // id ye göre iþlemleri gerçekleþtirme
        Product GetById(int id);
        // product listesi oluþturuldu
        List<Product> GetAll();
        
        // oluþtur, güncelle ve sil fonksiyonlarý oluþturldu
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}