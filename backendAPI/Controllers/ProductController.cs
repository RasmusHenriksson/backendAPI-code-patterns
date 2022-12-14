using backendAPI.Data;
using backendAPI.Handlers;
using backendAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductHandler _productHandler;

        public ProductController(IProductHandler productHandler)
        {
            _productHandler = productHandler;
        }
        // Den här hanterar enbart produkter enligt CRUD och följer Single Responsibility Principle
        // GET: api/ProductEntities
        //[HttpGet]

        //public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
        //{
        //    var items = new List<ProductModel>();

        //    foreach (var item in await _context.Products.ToListAsync())
        //    {

        //        items.Add(new ProductModel(
        //        item.Title,
        //        item.Category,
        //        item.Price,
        //        item.imgUrl
               
        //    ));

        //    }

        //    return items;
        //}
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productHandler.GetAllAsync();
            return new OkObjectResult(products);
        }
    }
}
