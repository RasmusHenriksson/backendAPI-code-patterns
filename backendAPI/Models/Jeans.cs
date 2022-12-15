using backendAPI.Interfaces;

namespace backendAPI.Models
{
    /* - Interface Segregation Principle - 
     Här ärver jag ifrån mitt interface som har unika egenskaper för just Jeans*/
    public class Jeans : IJeans
    {
        public bool IsStretched { get; set; }
        public string Size { get; set; } = null!;
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public CategoryModel Category { get; set; }
        public decimal Price { get; set; } 
        public string imgUrl { get; set; } = null!;
    }
}
