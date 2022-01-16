namespace Buxis.Sample.ApplicationCore.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Price { get; set; }

        public List<ProductAttribute> ProductAttributes { get; set; } = new();
    }
}
