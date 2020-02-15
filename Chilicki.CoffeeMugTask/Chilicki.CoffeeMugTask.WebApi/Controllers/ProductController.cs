using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chilicki.CoffeeMugTask.Application.Dtos;
using Chilicki.CoffeeMugTask.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chilicki.CoffeeMugTask.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService productService;

        public ProductController(
            ProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await productService.GetAll());

        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Guid id)
            => Ok(await productService.Find(id));

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductDataDto dto)
        {
            var product = await productService.Create(dto);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] ProductDataDto dto)
        {
            await productService.Update(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await productService.Delete(id);
            return NoContent();
        }
    }
}
