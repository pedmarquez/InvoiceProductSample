using Buxis.Sample.ApplicationCore.DTOs;
using Buxis.Sample.ApplicationCore.Entities;
using Buxis.Sample.ApplicationCore.Interfaces;
using Buxis.Sample.Infrastructure;

namespace Buxis.Sample.API.Services
{
    public class InvoiceService: IInvoiceService
    {
        private readonly BuxiDbContext db;

        public InvoiceService(BuxiDbContext db)
        {
            this.db = db;
        }

        public async Task<InvoiceDto> CreateAsync(CreateInvoiceDto model)
        {
            var invoice = new Invoice();

            foreach (var pid in model.Products)
            {
                var product = await db.Product.FindAsync(pid);

                invoice.InvoiceItems.Add(new InvoiceItem
                {
                    ProductId = pid,
                    Price = product.Price
                });
            }

            db.Invoice.Add(invoice);

            await db.SaveChangesAsync();

            //TODO: map to dto

            return new InvoiceDto
            {
                Id = invoice.Id
            };
        }
    }
}
