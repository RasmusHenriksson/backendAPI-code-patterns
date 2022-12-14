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

    /* - Single Responsibility Pinciple - 
    Jag har brytit ut ifrån min handler och skapat den här factoryn
    för att få bort beroendet i min handler och för att följa Single Responsibility Principle. */

    /* - Open Closed Pinciple - 
    Vi kommer aldrig behöva ändra någonting i den här klassen men vi kan importera och extenda nya entiteter 
    och factories och därefter följer vi Open Closed Principle */

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
        // Använder mig enbart av en factory för att alla produkter kommer att se likadana ut
        public List<ProductEntity> ProductList()
        {
            return new List<ProductEntity>();
        }
    }
}