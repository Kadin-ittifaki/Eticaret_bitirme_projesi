namespace shopapp.entity
{
    // �r�n kategori s�n�f olu�turldu
    public class ProductCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}