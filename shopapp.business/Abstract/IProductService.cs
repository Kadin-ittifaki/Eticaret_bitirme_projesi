using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IProductService
    {
        //Entity veritaban�m�z ile yaz�l�m�m�z aras�nda
        //ili�ki kurmam�z� sa�layan kal�c� nesnelerdir.

        // id ye g�re i�lemleri ger�ekle�tirme
        Product GetById(int id);
        // product listesi olu�turuldu
        List<Product> GetAll();
        
        // olu�tur, g�ncelle ve sil fonksiyonlar� olu�turldu
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}