using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    // IRepository'e Categori t�r�nde nesneler g�nderece�iz
    public interface ICategoryRepository: IRepository<Category>
    {
        // g�nderilen nesneler listelenecek
        List<Category> GetPopularCategories();
    }
}