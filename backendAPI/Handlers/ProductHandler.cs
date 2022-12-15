using backendAPI.Data;
using backendAPI.Factories;
using backendAPI.Interfaces;
using backendAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendAPI.Handlers
{
    /* - Single Responsibility Pinciple - 
    Jag har brytit ut ifrån min controller och den här handlern
    hanterar enbart mina funktioner och följer Single Responsibility Principle. */

    /* - Open Closed Pinciple - 
    Vi kommer aldrig behöva ändra någonting i den här klassen men vi kan importera och extenda nya funktioner
    som följer CRUD och därefter följer vi Open Closed Principle */

    /* - Liskov Substitution Principle - 
    Här ärver ProductHandler ifrån IProductHandler för att bryta ut mitt interface så att jag uppnår Single Responsibility Principle. */

    /* - Dependency Inversion Principle
     * Har ingen high level variant på detta eftersom jag har gjort en dependency injection och flyttat ut min IProductFactory. */

    public interface IProductHandler
    {
        Task<IEnumerable<ProductModel>> GetAllAsync();       
    }
    public class ProductHandler : IProductHandler
    {
        private readonly DataContext _sql;
        private readonly IProductFactory _factory;      
        public ProductHandler(DataContext sql, IProductFactory factory)
        {          
            _sql = sql;
            _factory = factory;
        }

        /* Den här hanterar funktionaliteten för att hämta alla produkter.*/
        public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            List<ProductModel> products = _factory.ProductList();

            foreach (var productEntity in await _sql.Products.Include(x => x.Category).ToListAsync())
                products.Add(_factory.Product(productEntity));
 
            return products;
        }
        





    }

        
    }
   