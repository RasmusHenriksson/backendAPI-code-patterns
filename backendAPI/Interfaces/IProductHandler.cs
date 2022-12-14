using backendAPI.Models;

namespace backendAPI.Interfaces
{
    public interface IProductHandler
    {
        /* - Single Responsibility Pinciple - 
        Jag har brytit ut detta interface från min handler för att följa Single Responsibility Principle. */

        /* - Open Closed Pinciple - 
         Vi kommer aldrig behöva ändra någonting i den här klassen men vi kan extenda detta interface
         och därefter följer vi Open Closed Principle */

        Task CreateAsync(ProductModel req);
        Task<IEnumerable<ProductEntity>> GetAllAsync();
        Task<ProductEntity> GetAsync(int id);

    }
}
