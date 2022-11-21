using System.Collections.Generic;

namespace shopapp.data.Abstract
{
    public interface IRepository<T>
    {
        //Generic'ler tasarland���m�z interface, class, metod yada parametrelerin
        //(arg�manlar�n) belirli bir tip i�in de�il bir �ablon yap�s�na uyan her tip i�in �al��mas�n� sa�layan bir yap�d�r.
        
        // id ile i�lemleri ger�ekle�tiriyoruz
        T GetById(int id);

        // t�m liste elemalar� generic t�r�nde
        List<T> GetAll();

        // olu�tur, g�ncelle ve sil i�lemleri generic tipte
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}