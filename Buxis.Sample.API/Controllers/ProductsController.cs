using Buxis.Sample.ApplicationCore.DTOs;
using Buxis.Sample.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Buxis.Sample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService service;

        public ProductsController(IProductService service)
        {
            this.service = service;
        }


        [HttpGet]
        public async Task<ActionResult<ProductDto[]>> Get()
        {
            return Ok(await service.GetAllAsync());
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto[]>> Post(CreateProductDto input)
        {
            var product = await service.CreateAsync(input);
            return Created("", product);
        }
    }
}
