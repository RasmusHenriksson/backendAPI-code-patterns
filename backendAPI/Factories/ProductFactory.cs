using backendAPI.Interfaces;
using backendAPI.Models;

namespace backendAPI.Factories
{
    public interface IProductFactory
    {
        ProductEntity ProductEntity();
        ProductModel Product(ProductEntity productEntity);
        List<ProductModel> ProductList();
    }

    /* - Single Responsibility Pinciple - 
    Jag har brytit ut ifrån min handler och skapat den här factoryn
    för att få bort beroendet i min handler och för att följa Single Responsibility Principle. */

    /* - Open Closed Pinciple - 
    Vi kommer aldrig behöva ändra någonting i den här klassen men vi kan importera och extenda nya entiteter 
    och factories och därefter följer vi Open Closed Principle. */

    /* - Liskov Substitution Principle - 
    Här ärver ProductFactory ifrån IProductFactory som innehåller allting med produkter att göra och
    är implementerat i Program.cs med ett interface .*/

    /* - Interface Segregation Principle - */

    /* - Dependency Inversion Principle - */

    public class ProductFactory : IProductFactory
    {
        
        /* Här har jag Tagit bort alla dependency delar och 
        använder mig enbart av en factory för att alla produkter kommer att se likadana ut. */
        public ProductModel Product(ProductEntity productEntity)
        {
            return new ProductModel()
            {
                Id = productEntity.Id,
                Title = productEntity.Title,
                Price = productEntity.Price,
                imgUrl = productEntity.imgUrl,
                Category = new(productEntity.Category.CategoryId, productEntity.Category.CategoryName)
               
            };
        }
        public List<ProductModel> ProductList()
        {
            return new List<ProductModel>();
        }

        public ProductEntity ProductEntity()
        {
            return new ProductEntity();
        }


    }
}