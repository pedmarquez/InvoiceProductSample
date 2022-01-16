namespace Buxis.Sample.ApplicationCore.Entities
{
    public class ProductAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Product { get; set; }= new();
    }
}
