using backendAPI.Interfaces;

namespace backendAPI.Models
{
    /* - Interface Segregation Principle - 
     Här ärver jag ifrån mitt interface som har unika egenskaper för just Sweater*/
    public class Sweater : ISweater
    {
        public string Size { get; set; } = null!;
        public bool HasZipper { get; set; }
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public CategoryModel Category { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; } = null!;
        public string imgUrl { get; set; } = null!;
    }
}
