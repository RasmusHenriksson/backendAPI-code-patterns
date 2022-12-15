namespace backendAPI.Interfaces
{
    /* - Liskov Substitution Principle -
        Detta interface ärver ifrån IProductModel som gör det möjligt att skapa flera produkter med samma bas egenskaper
        utan att ändra orginalet samt att jag kan följa Interface Segregation Principle om jag vill skapa produkter med enskilda
        egenskaper. */
    public interface IJeans : IProductModel
    {
        public bool IsStretched { get; set; }

        public string Size { get; set; }
    }
}
