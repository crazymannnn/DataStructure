using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EcommerceController : ControllerBase
    {
        private readonly ILogger<EcommerceController> _logger;

        public EcommerceController(ILogger<EcommerceController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ShowAll")]
        public IActionResult Show() {
            var customers = Storage.Database.Customers;
            return Ok(customers);
        }

        [HttpPut("AddProduct")]
        public IActionResult AddProduct(int idCustomer, int idProduct) {
            var result = CartService.AddToCart(idCustomer, idProduct);
            if (result) {
                return Ok();
            }
            return BadRequest("not found");
        }
    }
}
