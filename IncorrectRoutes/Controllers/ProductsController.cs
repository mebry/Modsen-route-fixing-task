using Microsoft.AspNetCore.Mvc;

namespace IncorrectRoutes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet("GetProducts")]
        public IActionResult AllProducts()
        {
            return NoContent();
        }

        [HttpGet("get-by-id/{productId}")]
        public IActionResult GetProductById(int productId)
        {
            return NoContent();
        }

        [HttpGet("{productId}/get-categories")]
        public IActionResult GetProductCategories(int productId)
        {
            return NoContent();
        }

        [HttpPost("create")]
        public IActionResult CreateProduct([FromBody] ProductDto productDto)
        {
            return NoContent();
        }

        [HttpPut("update-{productId}")]
        public IActionResult UpdateProduct(int productId, [FromBody] ProductDto productDto)
        {
            return NoContent();
        }

        [HttpDelete("delete/{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            return NoContent();
        }
    }
}