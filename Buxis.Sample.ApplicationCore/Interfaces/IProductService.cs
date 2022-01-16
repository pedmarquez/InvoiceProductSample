using Buxis.Sample.ApplicationCore.DTOs;

namespace Buxis.Sample.ApplicationCore.Interfaces
{
    public interface IProductService
    {
        Task<ProductDto[]> GetAllAsync();

        Task<ProductDto> CreateAsync(CreateProductDto model);
    }
}
