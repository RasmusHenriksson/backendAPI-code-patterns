using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendAPI.Models
{
    public class Product
    {
      
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Category { get; set; } = null!;
        public decimal Price { get; set; }
        public string imgUrl { get; set; } = null!;
    }
}
