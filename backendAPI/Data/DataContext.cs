using backendAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace backendAPI.Data
{
    /* Jag använder mig utav MVC principen med Models, Controllers och Views men eftersom det saknas vyer i mitt API 
     * så finns den delen inte med. Men jag utgår ifrån denna princip oavsett. 
     
     Den andra principen MVVM går inte att applicera på mitt Web API då den saknar vyer.*/

    /* - Single Responsibility Pinciple - 
     Här har jag utgått ifrån Single Responsibility Principle eftersom den här klassen bara har hand om min dataContext till SQL. */

    /* - Open Closed Pinciple - 
    Vi kommer aldrig behöva ändra någonting i den här klassen men vi kan extenda genom att lägga till nya 
    DbSets och följer därför Open Closed Principle. */

    /* - Liskov Substitution Principle - 
    Här ärver DataContext ifrån DbContext för att jag ska ha åtkomst till databasen ifrån mina entiteter. */

    /* - Interface Segregation Principle - */

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
