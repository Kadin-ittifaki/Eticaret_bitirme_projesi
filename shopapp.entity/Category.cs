using System.Collections.Generic;

namespace shopapp.entity
{
    // category s�n�f� olu�turuldu
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        
    }
}