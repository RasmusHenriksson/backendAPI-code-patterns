using backendAPI.Interfaces;
using backendAPI.Models;

namespace backendAPI.Factories
{
    public interface IProductFactory : IFactory
    {
        ProductEntity ProductEntity();
        ProductEntity Product(ProductEntity productEntity);
        List<ProductEntity> ProductList();
    }

    public class ProductFactory : IProductFactory
    {
        public ProductEntity ProductEntity()
        {
            return new ProductEntity();
        }

        public ProductEntity Product(ProductEntity productEntity)
        {
            return new ProductEntity()
            {
                Id = productEntity.Id,
                Title = productEntity.Title,
                Category= productEntity.Category,
                Price = productEntity.Price,
                imgUrl = productEntity.imgUrl
            };
        }
        //Tagit bort alla dependency delar
        public List<ProductEntity> ProductList()
        {
            return new List<ProductEntity>();
        }
    }
}