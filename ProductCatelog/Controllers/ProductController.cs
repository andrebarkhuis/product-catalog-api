using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCatelog.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        // Inject your repository, service, or DbContext here.
        // For this example, I'm just using a placeholder.

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            // Fetch products from your repository, service, or DbContext.
            // For this example, I'm returning a static list.
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product A" },
                new Product { Id = 2, Name = "Product B" }
            };

            return Ok(products);
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            // Fetch the product based on ID from your repository, service, or DbContext.
            // This is a static example.
            var product = new Product { Id = id, Name = "Product A" };

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            // Add product to your repository, service, or DbContext.

            // Return the product with a Created status.
            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            // Update the product in your repository, service, or DbContext.

            return NoContent();
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            // Remove the product from your repository, service, or DbContext.

            return NoContent();
        }
    }

    // Sample Product model
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

