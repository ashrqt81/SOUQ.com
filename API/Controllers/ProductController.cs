using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly StoreDBContext _storeDBContext;
        public ProductController(StoreDBContext storeDBContext)
        {
            _storeDBContext = storeDBContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> getProducts()
        {
            var products = await _storeDBContext.products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]//parameter
        public async Task <ActionResult<Product>> getProductById(int id)
        {
            return await _storeDBContext.products.FindAsync(id);
        }
    }
}
