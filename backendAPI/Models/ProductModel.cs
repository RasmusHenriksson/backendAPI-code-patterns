namespace backendAPI.Models
{
    public class ProductModel
    {
        public ProductModel(string title, string category, decimal price, string imgUrl)
        {
            Title = title;
            Category = category;
            Price = price;
            this.imgUrl = imgUrl;
        }
        /* - Single Responsibility Pinciple - 
         Den här klassen gör bara en sak eftersom den bara tar hand om min produkt modell. */

        /* - Open Closed Pinciple - 
         Vi kommer aldrig behöva ändra någonting i den här klassen och följer därför Open Closed Principle. */

        /* - Liskov Substitution Principle - 
         Här ärver jag ingenting. */

        /* - Interface Segregation Principle - */



        public string Title { get; set; } = null!;
        public string Category { get; set; } = null!;
        public decimal Price { get; set; }
        public string imgUrl { get; set; } = null!;



    }
}
