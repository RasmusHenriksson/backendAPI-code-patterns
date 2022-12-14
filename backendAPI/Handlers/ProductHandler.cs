using backendAPI.Data;
using backendAPI.Factories;
using backendAPI.Interfaces;
using backendAPI.Models;
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

    /* - Interface Segregation Principle - */

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
        // för att få bort beroendet så använder jag mig utav en factory.
        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
        {
            List<ProductEntity> products = _factory.ProductList();

            foreach (var productEntity in await _sql.Products.ToListAsync())
                products.Add(_factory.Product(productEntity));

            return products;
        }
        /* Den här hanterar funktionaliteten för att skapa produkter om vi vill bygga det.*/
        public Task CreateAsync(ProductModel req)
        {
            throw new NotImplementedException();
        }
        //public async Task CreateAsync(ProductModel productModel)
        //{
        //    var productEntity = _factory.ProductEntity();
        //    productEntity.Title = productModel.Title;
        //    productEntity.Price = productModel.Price;
        //    _sql.Add(productEntity);
        //    await _sql.SaveChangesAsync();
        //}    

        /* Den här hanterar eventuell funktionalitet i framtiden för att söka efter id på en specifik produkt. */
        public Task<ProductEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}