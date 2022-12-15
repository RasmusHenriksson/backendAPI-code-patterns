using System.ComponentModel.DataAnnotations;

namespace backendAPI.Models
{
    /* - Single Responsibility Pinciple - 
         Den här klassen gör bara en sak eftersom den bara tar hand om min kategori entitet. */

    /* - Open Closed Pinciple - 
         Vi kommer aldrig behöva ändra någonting i den här klassen och följer därför Open Closed Principle*/
    public class CategoryEntity
    {
        public CategoryEntity(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } 

        public ICollection<ProductEntity> Products { get; set; } 
    }
}

        



       