namespace Buxis.Sample.ApplicationCore.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; } = new();
    }
}
