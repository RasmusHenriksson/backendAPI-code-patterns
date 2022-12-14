using backendAPI.Data;
using backendAPI.Factories;
using backendAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace backendAPI.Handlers
{
    public interface IProductHandler
    {
        Task CreateAsync(ProductModel req);
        Task<IEnumerable<ProductEntity>> GetAllAsync();
        Task<ProductEntity> GetAsync(int id);
        
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

        public async Task CreateAsync(ProductModel req)
        {
            var productEntity = _factory.ProductEntity();
            productEntity.Title = req.Title;
            productEntity.Price = req.Price;

            _sql.Add(productEntity);
            await _sql.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
        {
            List<ProductEntity> products = _factory.ProductList();

            foreach (var productEntity in await _sql.Products.ToListAsync())
                products.Add(_factory.Product(productEntity));

            return products;
        }

        public Task<ProductEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}