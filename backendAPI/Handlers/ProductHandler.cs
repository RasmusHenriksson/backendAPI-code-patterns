using backendAPI.Data;
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

    public class ProductHandler : IProductHandler
    {
        private readonly DataContext _sql;
        private readonly Factories.IProductFactory _factory;      
        public ProductHandler(DataContext sql, Factories.IProductFactory factory)
        {
            
            _sql = sql;
            _factory = factory;
        }

        public Task CreateAsync(ProductModel req)
        {
            throw new NotImplementedException();
        }

        /* Den här hanterar funktionaliteten för att skapa produkter.*/
        //public async Task CreateAsync(ProductModel productModel)
        //{
        //    var productEntity = _factory.ProductEntity();
        //    productEntity.Title = productModel.Title;
        //    productEntity.Price = productModel.Price;

        //    _sql.Add(productEntity);
        //    await _sql.SaveChangesAsync();
        //}    


        /* Den här hanterar funktionaliteten för att hämta alla produkter.*/
        // för att få bort beroendet så använder jag mig utav en factory.
        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
        {
            List<ProductEntity> products = _factory.ProductList();

            foreach (var productEntity in await _sql.Products.ToListAsync())
                products.Add(_factory.Product(productEntity));

            return products;
        }
        /* Den här hanterar eventuell funktionalitet i framtiden för att söka efter id på en specifik produkt. */
        public Task<ProductEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}