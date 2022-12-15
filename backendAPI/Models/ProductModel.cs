namespace backendAPI.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }

        public ProductModel(int id, string title, decimal price, string imgUrl, CategoryModel category)
        {
            Id = id;
            Title = title;
            Price = price;
            this.imgUrl = imgUrl;
            Category = category;
        }


        /* - Single Responsibility Pinciple - 
         Den här klassen gör bara en sak eftersom den bara tar hand om min produkt modell. */

        /* - Open Closed Pinciple - 
         Vi kommer aldrig behöva ändra någonting i den här klassen och följer därför Open Closed Principle. */

        /* - Liskov Substitution Principle - 
         Här ärver jag ingenting. */

        /* - Interface Segregation Principle - 
         Jag väljer att inte använda ISP för att det skapar för mycket komplex med mitt ändamål */

        /* - Dependency Inversion Principle - */


        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }
        public string imgUrl { get; set; } = null!;
        public CategoryModel Category { get; set; }



    }
}
