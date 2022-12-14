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

        public string Title { get; set; } = null!;
        public string Category { get; set; } = null!;
        public decimal Price { get; set; }
        public string imgUrl { get; set; } = null!;



    }
}
