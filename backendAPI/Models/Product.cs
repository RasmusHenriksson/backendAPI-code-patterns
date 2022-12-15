using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendAPI.Models
{
    public class Product
    {
        /* - Single Responsibility Pinciple - 
           Den här klassen gör bara en sak eftersom den bara tar hand om min produkt. */

        /* - Open Closed Pinciple - 
         Vi kommer aldrig behöva ändra någonting i den här klassen och följer därför Open Closed Principle*/

        /* - Liskov Substitution Principle - 
        Denna klass ärver ingenting. */

        /* - Interface Segregation Principle - */

        /* - Dependency Inversion Principle - */
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public CategoryEntity Category { get; set; }
        public decimal Price { get; set; }
        public string imgUrl { get; set; } = null!; 
    }
}
