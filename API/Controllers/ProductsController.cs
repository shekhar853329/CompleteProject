using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository repos;

        public ProductsController(IProductRepository repos)
        {
            this.repos = repos;
        }
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts()
        {
            var products = await repos.GetProductsAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await repos.GetProductByIdAsync(id);
            return Ok(product); 
        }
    }
}