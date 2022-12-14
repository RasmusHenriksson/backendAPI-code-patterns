using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendAPI.Models
{
    public class ProductEntity
    {
       

        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Category { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public string imgUrl { get; set; } = null!;
    }
}

        



       