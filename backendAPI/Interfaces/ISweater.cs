namespace backendAPI.Interfaces
{
    public interface ISweater : IProductModel
    {
        /* - Liskov Substitution Principle -
             Detta interface ärver ifrån IProductModel som gör det möjligt att skapa flera produkter med samma bas egenskaper
             utan att ändra orginalet samt att jag kan följa Interface Segregation Principle om jag vill skapa produkter med enskilda
             egenskaper. */
        public string Size { get; set; }

        public bool HasZipper { get; set; }

    }
}
