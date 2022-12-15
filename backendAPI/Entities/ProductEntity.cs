using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendAPI.Models
{
    public class ProductEntity
    {
        public ProductEntity()
        {
        }

        public ProductEntity(int id, string title, decimal price, string imgUrl, int categoryId, CategoryEntity category)
        {
            Id = id;
            Title = title;
            Price = price;
            this.imgUrl = imgUrl;
            CategoryId = categoryId;
            Category = category;
        }



        /* - Single Responsibility Pinciple - 
         Den här klassen gör bara en sak eftersom den bara tar hand om min produkt entitet. */

        /* - Open Closed Pinciple - 
         Vi kommer aldrig behöva ändra någonting i den här klassen och följer därför Open Closed Principle*/


        /* - Dependency Inversion Principle - */

        [Key]
        public int Id { get; set; }

        public string Title { get; set; } = null!;
      

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public string imgUrl { get; set; } = null!;

        public int CategoryId { get; set; }

        public CategoryEntity Category { get; set; } 
    }
}

        



       