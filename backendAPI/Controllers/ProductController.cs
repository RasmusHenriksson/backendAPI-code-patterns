using backendAPI.Data;
using backendAPI.Handlers;
using backendAPI.Interfaces;
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
        /* - Single Responsibility Pinciple - 
         Den här hanterar enbart mina routes och följer Single Responsibility Principle. */

        /* - Open Closed Pinciple - 
        Vi kommer aldrig behöva ändra någonting i den här klassen men vi kan extenda genom att lägga till nya 
        Routes och följer därför Open Closed Principle */


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productHandler.GetAllAsync();
            return new OkObjectResult(products);
        }
    }
}
