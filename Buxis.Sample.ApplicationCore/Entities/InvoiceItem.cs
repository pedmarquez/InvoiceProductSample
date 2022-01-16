namespace Buxis.Sample.ApplicationCore.Entities
{
    public class InvoiceItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
