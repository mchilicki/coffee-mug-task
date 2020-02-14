﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chilicki.CoffeeMugTask.Data.Dtos;
using Chilicki.CoffeeMugTask.Data.Services;
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
            => Ok(await productService.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductDto product)
            => Ok(await productService.Create(product));

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] ProductDto product)
            => Ok(await productService.Update(product));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
            => Ok(await productService.Delete(id));
    }
}