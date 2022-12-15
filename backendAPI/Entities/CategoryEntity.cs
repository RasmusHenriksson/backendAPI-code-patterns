using System.ComponentModel.DataAnnotations;

namespace backendAPI.Models
{
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

        



       