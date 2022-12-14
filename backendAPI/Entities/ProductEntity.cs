using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendAPI.Models
{
    public class ProductEntity
    {

        /* - Single Responsibility Pinciple - 
         Den här klassen gör bara en sak eftersom den bara tar hand om min produkt entitet. */

        /* - Open Closed Pinciple - 
         Vi kommer aldrig behöva ändra någonting i den här klassen och följer därför Open Closed Principle*/

        /* - Liskov Substitution Principle - 
        Denna klass ärver ingenting. */

        /* - Interface Segregation Principle - */

        /* - Dependency Inversion Principle - */

        [Key]
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Category { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public string imgUrl { get; set; } = null!;
    }
}

        



       