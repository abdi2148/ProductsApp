using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductsApp.Core.ApplicationServices.Services;
using ProductsApp.Core.DomainServices;
using ProductsApp.Core.Entities;

namespace ProductsAppWebApi.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {

            _productService = productService;
        }
        // GET: api/ProductController
        [Authorize]
        [HttpGet]
        public IEnumerable<Product> Get() => _productService.GetProducts();

        // GET api/ProductController/5
        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return _productService.ReadById(id);
        }

        // POST api/ProductController
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult<Product> Post([FromBody] Product product)
        {
            return _productService.CreateProduct(product);
        }

        // PUT api/ProductController/5
        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public ActionResult<Product> Put(int id, [FromBody] Product product)
        {
            return _productService.UpdateProduct(product);
        }

        // DELETE api/ProductController/5
        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public ActionResult<Product> Delete(int id)
        {
            return _productService.DeleteProduct(id);
        }
    }
}