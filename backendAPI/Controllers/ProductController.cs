using backendAPI.Data;
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
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ProductEntities
        [HttpGet]

        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
        {
            var items = new List<ProductModel>();

            foreach (var item in await _context.Products.ToListAsync())
            {

                items.Add(new ProductModel(
                item.Title,
                item.Category,
                item.Price,
                item.imgUrl
               
            ));

            }

            return items;
        }
    }
}
