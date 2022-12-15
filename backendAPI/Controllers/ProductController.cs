using backendAPI.Data;
using backendAPI.Handlers;
using backendAPI.Interfaces;
using backendAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

/* Jag använder mig utav MVC principen med Models, Controllers och Views men eftersom det saknas vyer i mitt API 
   så finns den delen inte med. Men jag utgår ifrån denna princip oavsett.

    Den andra principen MVVM går inte att applicera på mitt Web API då den saknar vyer.*/

namespace backendAPI.Controllers
{
    /* - Single Responsibility Pinciple - 
         Den här hanterar enbart mina routes och följer Single Responsibility Principle. */

    /* - Open Closed Pinciple - 
         Vi kommer aldrig behöva ändra någonting i den här klassen men vi kan extenda genom att lägga till nya 
         Routes och följer därför Open Closed Principle */

    /* - Liskov Substitution Principle - 
         Här ärver ProductController ifrån ControllerBase för att jag ska kunna använda mig utav
         dess bas klasser och här används OkOBjectResult som ger en status 200 OK response */

    /* - Dependency Inversion Principle - 
         Här har jag uppnått Dependency Inversion Principle genom att jag har gjort en dependency injection och flyttat ut min IProductHandler. */

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductHandler _productHandler;
        private readonly DataContext _context;

        public ProductController(IProductHandler productHandler, DataContext context)
        {
            _productHandler = productHandler;
            _context = context;
        }      

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productHandler.GetAllAsync();

            return new OkObjectResult(products);
        }




        [HttpGet("{category}")]

        public async Task<IActionResult> GetCategoryAsync()
        {
            var items = await _context.Products.Include(x => x.Category).ToListAsync();
            List<IProductModel> products = new List<IProductModel>();

            foreach (var item in items)
            {
                if (item.Category.CategoryName == "Sweater")
                    products.Add(new Sweater
                    {
                        Id = item.CategoryId,
                        Size = "Large",
                        HasZipper = true
                    });
            }

            return new OkObjectResult(products);



        }
    }
}

