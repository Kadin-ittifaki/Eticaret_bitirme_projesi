using System.Collections.Generic;

namespace shopapp.data.Abstract
{
    public interface IRepository<T>
    {
        //Generic'ler tasarlandýðýmýz interface, class, metod yada parametrelerin
        //(argümanlarýn) belirli bir tip için deðil bir þablon yapýsýna uyan her tip için çalýþmasýný saðlayan bir yapýdýr.
        
        // id ile iþlemleri gerçekleþtiriyoruz
        T GetById(int id);

        // tüm liste elemalarý generic türünde
        List<T> GetAll();

        // oluþtur, güncelle ve sil iþlemleri generic tipte
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}