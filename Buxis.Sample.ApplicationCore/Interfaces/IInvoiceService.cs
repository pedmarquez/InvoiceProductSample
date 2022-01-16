using Buxis.Sample.ApplicationCore.DTOs;

namespace Buxis.Sample.ApplicationCore.Interfaces
{
    public interface IInvoiceService
    {
        Task<InvoiceDto> CreateAsync(CreateInvoiceDto model);
    }
}
