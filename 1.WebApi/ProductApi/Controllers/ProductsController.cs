using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Model;
using ProductApi.Repository;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductRepository productsRepository;
        public ProductsController(IProductRepository productRepo)
        {
            productsRepository = productRepo;
        }

        [HttpGet]

        public IActionResult AllProducts() {

            return Ok(productsRepository.GetProduct());
        }

        [HttpGet("amount/{amount}")]

        public IActionResult ProductGreaterThanAmount([FromRoute] int amount) {


            return Ok(productsRepository.GetProductGreater(amount));
        
        }

        [HttpPost]

        public IActionResult AddProduct([FromBody] Product product) {

            var productAdded = productsRepository.SendProduct(product);

            if (productAdded != null)
            {
                return Ok(product);
            }

            return StatusCode(401);
                   
        }


        [HttpPut]

        public IActionResult UpdateProduct([FromQuery] Guid id, [FromBody] Product product)
        {
            var productExist = productsRepository.UpdateProduct(id,product);

            if (productExist)
            {
                return Ok("Sucessfully updated the product");
            }
            return NotFound($"product with id:{id} not exist");
        }

        [HttpDelete]

        public IActionResult DeleteProdcut([FromQuery] Guid id) {

            var productDeleted = productsRepository.DeleteProduct(id);

            if (productDeleted == true)
            {
                return Ok("Product Deleted Successfully");
            }

            return NotFound($"Product with id:{id} not exist");
        }

    }
}
