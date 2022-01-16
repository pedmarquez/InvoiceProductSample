using Buxis.Sample.ApplicationCore.DTOs;
using Buxis.Sample.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Buxis.Sample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService service;

        public InvoiceController(IInvoiceService service)
        {
            this.service = service;
        }
        [HttpPost]
        public async Task<ActionResult<InvoiceDto[]>> Post(CreateInvoiceDto input)
        {
            var product = await service.CreateAsync(input);
            return Created("", product);
        }
    }


}
