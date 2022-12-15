using backendAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendAPI.Interfaces
{
    public interface IProductModel 
    {
        /* - Interface Segregation Principle - 
         Jag har skapat ett interface här som kan ge sitt arv till nya modeller utan att det skapar problem och följer Interface Segregation Principle*/

        public string Title { get; set; } 
        public decimal Price { get; set; }
        public string imgUrl { get; set; }
        public CategoryModel Category { get; set; }
    }
}
