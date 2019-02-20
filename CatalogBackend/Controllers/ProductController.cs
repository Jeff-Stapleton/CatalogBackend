using System;
using System.Collections.Generic;
using System.Linq;
using CatalogBackend.Data;
using CatalogBackend.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatalogBackend.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductService productService;

        ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            return productService.Read();
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]ProductModel newProduct)
        {
            productService.Create(newProduct);
        }
    }
}
