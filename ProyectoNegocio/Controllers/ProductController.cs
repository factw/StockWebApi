using Microsoft.AspNetCore.Mvc;
using ProyectoNegocio.Service.Product;

namespace ProyectoNegocio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProductListAsync().Result);
        }
    }
}
